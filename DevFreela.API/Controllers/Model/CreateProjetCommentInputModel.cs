namespace DevFreela.API.Controllers.Model
{
    public class CreateProjetCommentInputModel
    {
        public string Content { get; set; }

        public int IdProject { get; set; }

        public int IdUser { get; set; }
    }
}
