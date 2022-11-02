using Domain.Entities;

namespace Domain.Models
{
    public class FichaAlimentacaoModel : BaseEntity<long>
    {
        public long CafeDaManha1 { get; set; }
        public long CafeDaManha2 { get; set; }
        public long CafeDaManha3 { get; set; }
        public long CafeDaManha4 { get; set; }
        public long CafeDaManha5 { get; set; }
        public long Almoco1 { get; set; }
        public long Almoco2 { get; set; }
        public long Almoco3 { get; set; }
        public long Almoco4 { get; set; }
        public long Almoco5 { get; set; }
        public long CafeDaTarde1 { get; set; }
        public long CafeDaTarde2 { get; set; }
        public long CafeDaTarde3 { get; set; }
        public long CafeDaTarde4 { get; set; }
        public long CafeDaTarde5 { get; set; }
        public long Janta1 { get; set; }
        public long Janta2 { get; set; }
        public long Janta3 { get; set; }
        public long Janta4 { get; set; }
        public long Janta5 { get; set; }
    }
}
