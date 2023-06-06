using System;
using Entidades = Api.Adaptadores.BD.Entidades;
using DTOs = Dominio.DTOs;

namespace Api.Tests.Setup
{
    public static class MockDados
    {
        public static Entidades.Usuario GerarUsuario(bool paciente)
        {
            return new Entidades.Usuario
            {
                Nome = "Usuario",
                Email = "email@email.com",
                Senha = "senha",
                Paciente = paciente,
                DataNascimento = DateTime.Now.AddYears(-18)
            };
        }

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
    }
}