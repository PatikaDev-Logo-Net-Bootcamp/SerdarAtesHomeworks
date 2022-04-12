using ApartmentManagement.Domain.Entities;
using System.Collections.Generic;


namespace ApartmentManagement.Business.Abstracts
{
    public interface IBlockService
    {
        List<Block> GetAllBlock();
        void AddBlock(Block block);
        void UpdateBlock(Block block);
        void DeleteBlock(Block block);
    }
}
