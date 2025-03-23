using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.CategoryCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler(IRepository<Category> _categoryRepository)
    {
        public async Task Handle(UpdateCategoryCommand command)
        {
            var category = new Category
            {
                CategoryId = command.Id,
                CategoryName = command.CategoryName,
                ImageUrl = command.ImageUrl
            };
            
            await _categoryRepository.UpdateAsync(category);
        }
    }
}
