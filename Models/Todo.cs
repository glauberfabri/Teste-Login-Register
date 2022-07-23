using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id
        {
            get; set; 
        }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo é obrigatório!")]
        public string Title { get; set; }

        [DisplayName("Concluído")]
        public bool Done { get; set; }

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

         [DisplayName("Atualizado em")]
        public DateTime LastUpteDate { get; set; } = DateTime.Now;

        [DisplayName("Usuário")]
        public string User { get; set; }    
        
    }
}
