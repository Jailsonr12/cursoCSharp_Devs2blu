using System.ComponentModel;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum{
    public enum FlStatus {

        [Description("Excluido")]
        E = 0,
        [Description("Ativo")]
        A = 1,
        [Description("Inativo")]
        I = 2,

    }
}