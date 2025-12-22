using MorgueManager.Core.DTOs;

namespace MorgueManager.Core.Interfaces.Services
{
    public interface IPdfService
    {
        // Hàm nhận vào DTO chi tiết và trả về mảng byte (file PDF)
        byte[] GenerateHandoverRecord(CorpseDetailDto data);
    }
}