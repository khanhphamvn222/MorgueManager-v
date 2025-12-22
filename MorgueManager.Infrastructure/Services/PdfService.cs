using MorgueManager.Core.DTOs;
using MorgueManager.Core.Interfaces.Services;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace MorgueManager.Infrastructure.Services
{
    public class PdfService : IPdfService
    {
        public PdfService()
        {
            // Cấu hình License Cộng đồng (Miễn phí)
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public byte[] GenerateHandoverRecord(CorpseDetailDto data)
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    // Cấu hình trang A4
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontFamily("Arial").FontSize(11));

                    // 1. Header (Tiêu đề)
                    page.Header().Column(col =>
                    {
                        col.Item().Text("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM").Bold().FontSize(12).AlignCenter();
                        col.Item().Text("Độc lập - Tự do - Hạnh phúc").FontSize(12).AlignCenter();
                        col.Item().PaddingTop(5).LineHorizontal(1);

                        col.Item().PaddingTop(20).Text("BIÊN BẢN BÀN GIAO THI THỂ").Bold().FontSize(20).FontColor(Colors.Blue.Medium).AlignCenter();
                        col.Item().Text($"(Số phiếu: {data.Id:000000})").FontSize(10).Italic().AlignCenter();
                    });

                    // 2. Content (Nội dung)
                    page.Content().PaddingTop(20).Column(col =>
                    {
                        col.Item().Text($"Hôm nay, ngày {DateTime.Now:dd} tháng {DateTime.Now:MM} năm {DateTime.Now:yyyy}, tại Nhà đại thể Bệnh viện.").FontSize(11);
                        col.Item().PaddingTop(10).Text("Chúng tôi gồm có:").Bold();

                        // Bảng thông tin thi thể
                        col.Item().PaddingTop(10).Border(1).BorderColor(Colors.Grey.Lighten2).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(150);
                                columns.RelativeColumn();
                            });

                            // Helper function vẽ hàng
                            void AddRow(string label, string value)
                            {
                                table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(5).Text(label).SemiBold();
                                table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(5).Text(value);
                            }

                            AddRow("Họ và Tên:", data.FullName.ToUpper());
                            AddRow("Giới tính:", data.Gender);
                            AddRow("Số CCCD/Định danh:", data.IdentityNumber);
                            AddRow("Ngày giờ tiếp nhận:", data.ReceptionTime.ToString("HH:mm dd/MM/yyyy"));
                            AddRow("Vị trí lưu kho:", data.StorageLocation);
                            AddRow("Thời gian lưu:", $"{data.DaysInStorage} ngày");
                            AddRow("Tổng chi phí:", string.Format("{0:N0} VNĐ", data.TotalCost));
                            AddRow("Ghi chú:", data.Notes ?? "Không có");
                        });

                        col.Item().PaddingTop(15).Text("Đại diện gia đình/Người nhận xác nhận đã kiểm tra kỹ lưỡng, nhận bàn giao thi thể và tư trang (nếu có) đầy đủ.").Italic();
                    });

                    // 3. Footer (Chữ ký)
                    page.Footer().PaddingTop(20).Column(col =>
                    {
                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("ĐẠI DIỆN BÊN GIAO").Bold().AlignCenter();
                                c.Item().Text("(Ký, ghi rõ họ tên)").FontSize(9).Italic().AlignCenter();
                            });

                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("ĐẠI DIỆN BÊN NHẬN").Bold().AlignCenter();
                                c.Item().Text("(Ký, ghi rõ họ tên)").FontSize(9).Italic().AlignCenter();
                            });
                        });

                        col.Item().PaddingTop(30).Text("Hệ thống quản lý nhà xác - MorgueManager").FontSize(8).FontColor(Colors.Grey.Medium).AlignCenter();
                    });
                });
            });

            return document.GeneratePdf();
        }
    }
}