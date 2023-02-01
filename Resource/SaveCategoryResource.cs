using System.ComponentModel.DataAnnotations;

namespace Dws.Note_one.Api.Resource
{
    public class SaveCategoryResources
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set;}
    }
}