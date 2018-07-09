using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DAL_Entities
{
    public class Entities
    {
        public abstract class Utilizador
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

            public bool CheckLogin()
            {
                throw new NotImplementedException();
            }

        }

        public class Formador : Utilizador
        {
            public bool IsAdmin { get; set; }

            
        }


        public class Aluno : Utilizador
        {
            public int Turma { get; set; }
        }

        public class UFCD
        {
            public int Codigo { get; set; }
            public string Designacao { get; set; }
           

            public List<Questao> GetQuestoes()
            {
                throw new NotImplementedException();
            }

            public List<Formador> GetFormadores()
            {
                throw new NotImplementedException();
            }

        }

        public class Questao
        {
            public int Id { get; set; }
            public string Enunciado { get; set; }
            public int Ufcd { get; set; }
            public bool IsCheckBox { get; set; }
            public string ImagePath { get; set; }
            public List<Resposta> ListRespostas { get; set; }

        }

        public class Resposta
        {
            public int Id { get; set; }
            public string Corpo { get; set; }
            public int Questao { get; set; }
            public bool IsCorrect { get; set; }
           
        }

        public class Curso
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Designacao { get; set; }
            public bool IsCheckBox { get; set; }
            public string ImagePath { get; set; }
        }

        public class Turma
        {
            public int Id { get; set; }
            public string Descricao { get; set; }
            public int Curso { get; set; }
            
            public List<Aluno> GetAlunos()
            {
                throw new NotImplementedException();
            }

            public List<UFCD> GetUFCDs()
            {
                throw new NotImplementedException();
            }

        }

        public class AcaoFormacao
        {
            public int Id { get; set; }
            public int Turma { get; set; }
            public int Ufcd { get; set; }
            public int Formador { get; set; }
        }

        public class Exame
        {
            public int Id { get; set; }
            public AcaoFormacao AcaoFormacao { get; set; }
            public DateTime DataExame { get; set; }
            public List<TesteAluno> ListTestes { get; set; }

            public void StartExame()
            {
                throw new NotImplementedException();
            }

            public void CancelExame()
            {
                throw new NotImplementedException();
            }
        }

        public class TesteAluno
        {
            public int Id { get; set; }
            public int AcaoFormacao { get; set; }
            public int Aluno { get; set; }
            public bool LockMe { get; }
            public Dictionary<Questao,int> ListQuestao { get; set; }
            public double nota { get; }

            public void SubmitTeste()
            {
                throw new NotImplementedException();
            }

            public void SubmitResposta(int idResposta)
            {
                throw new NotImplementedException();
            }

            public void CreateListQuestao()
            {
                throw new NotImplementedException();
            }
        }

    }
}
