using System;
using Entidades = Api.Adaptadores.BD.Entidades;
using DTOs = Dominio.DTOs;

namespace Api.Tests.Setup
{
    public static class MockDados
    {
        public static Entidades.Atendimento GerarEntidadeAtendimento()
        {
            return new Entidades.Atendimento
            {
                CodigoLocalAtendimento = 1,
                Data = DateTime.Now,
                LocalAtendimento = "SUS",
                UsuarioId = 1,
                AtendimentoVacinas = new List<Entidades.AtendimentoVacina>
                {
                    new Entidades.AtendimentoVacina
                    {
                        AtendimentoId = 1,
                        VacinaId = 1
                    }
                }
            };
        }

        public static DTOs.Atendimento GerarDTOAtendimento()
        {
            return new DTOs.Atendimento
            {
                CodigoLocalAtendimento = 1,
                Data = DateTime.Now,
                LocalAtendimento = "SUS",
                UsuarioId = 1,
                Vacinas = new List<DTOs.AtendimentoVacina>
                {
                    new DTOs.AtendimentoVacina
                    {
                        AtendimentoId = 1,
                        VacinaId = 1
                    }
                }
            };
        }

        public static Entidades.Doenca GerarEntidadeDoenca()
        {
            return new Entidades.Doenca
            {
                Nome = "Covid",
                DataIdentificacao = DateTime.Now,
                Descricao = "Descricao"
            };
        }

        public static DTOs.Doenca GerarDTODoenca()
        {
            return new DTOs.Doenca
            {
                Nome = "Covid",
                DataIdentificacao = DateTime.Now,
                Descricao = "Descricao"
            };
        }

        public static Entidades.Patogeno GerarEntidadePatogeno()
        {
            return new Entidades.Patogeno
            {
                Nome = "CoronaVirus"
            };
        }

        public static Entidades.Sintoma GerarEntidadeSintoma()
        {
            return new Entidades.Sintoma
            {
                Descricao = "Febre"
            };
        }

        public static Entidades.TipoImunizacao GerarEntidadeTipoImunizacao()
        {
            return new Entidades.TipoImunizacao
            {
                Nome = "Vacina"
            };
        }

        public static Entidades.Usuario GerarEntidadeUsuario()
        {
            return new Entidades.Usuario
            {
                Nome = "Usuario",
                Email = "email@email.com",
                Senha = "senha",
                Paciente = true,
                DataNascimento = DateTime.Now.AddYears(-18)
            };
        }

        public static DTOs.Usuario GerarDTOUsuario()
        {
            return new DTOs.Usuario
            {
                Nome = "Usuario",
                Email = "email@email.com",
                Senha = "senha",
                Paciente = true,
                DataNascimento = DateTime.Now.AddYears(-18)
            };
        }

        public static Entidades.Vacina GerarEntidadeVacina()
        {
            return new Entidades.Vacina
            {
                Nome = "CoronaVac",
                DataFabricacao = DateTime.Now,
                DataAprovacao = DateTime.Now,
                DosesImunizacao = 2,
                PeriodoEntreDoses = 15,
                EficaciaComprovada = 70
            };
        }

        public static DTOs.Vacina GerarDTOVacina()
        {
            return new DTOs.Vacina
            {
                Nome = "CoronaVac",
                DataFabricacao = DateTime.Now,
                DataAprovacao = DateTime.Now,
                Doses = 2,
                PeriodoEntreDoses = 15,
                EficaciaComprovada = 70
            };
        }
    }
}