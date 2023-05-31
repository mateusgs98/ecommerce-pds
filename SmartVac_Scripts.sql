/*** CRIAÇÃO DA BASE DE DADOS **/

USE [SmartVac]
GO
/****** Object:  Table [dbo].[Atendimento_Vacinas]    Script Date: 22/01/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atendimento_Vacinas](
	[Id] [int] NOT NULL,
	[AtendimentoId] [int] NOT NULL,
	[VacinaId] [int] NOT NULL,
 CONSTRAINT [PK_Atendimento_Vacinas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Atendimentos]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atendimentos](
	[Id] [int] NOT NULL,
	[ResponsavelId] [int] NOT NULL,
	[PacienteId] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[LocalAtendimento] [varchar](50) NOT NULL,
	[CodigoLocalAtendimento] [int] NOT NULL,
 CONSTRAINT [PK_Atendimentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContraIndicacoes]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContraIndicacoes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ContraIndicacoes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doenca_Sintomas]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doenca_Sintomas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DoencaId] [int] NOT NULL,
	[SintomaId] [int] NOT NULL,
 CONSTRAINT [PK_Doenca_Sintomas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doencas]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doencas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[PatogenoId] [int] NULL,
	[DataIdentificacao] [date] NULL,
	[PaisId] [int] NULL,
	[Descricao] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Doencas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fabricantes]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fabricantes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[PaisId] [int] NULL,
 CONSTRAINT [PK_Fabricantes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FaixasEtarias]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FaixasEtarias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](200) NOT NULL,
 CONSTRAINT [PK_FaixasEtarias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente_ContraIndicacoes]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente_ContraIndicacoes](
	[Id] [int] NOT NULL,
	[PacienteId] [int] NOT NULL,
	[ContraIndicacaoId] [int] NOT NULL,
 CONSTRAINT [PK_Paciente_ContraIndicacoes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Genero] [smallint] NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[CodigoSUS] [varchar](50) NULL,
	[CPF] [varchar](14) NULL,
	[RG] [varchar](50) NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[ISO3] [char](3) NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patogenos]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patogenos](
	[Id] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Patogenos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sintomas]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sintomas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Sintomas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoImunizacao]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoImunizacao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoImunizacao] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](200) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Senha] [nvarchar](50) NULL,
	[Paciente] [bit] NOT NULL,
	[DataNascimento] [date] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacina_ContraIndicacao]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacina_ContraIndicacao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VacinaId] [int] NOT NULL,
	[ContraIndicacaoId] [int] NOT NULL,
 CONSTRAINT [PK_Vacina_ContraIndicacao] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacina_Doenca]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacina_Doenca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VacinaId] [int] NOT NULL,
	[DoencaId] [int] NOT NULL,
 CONSTRAINT [PK_Vacina_Doenca] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacina_FaixaEtaria]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacina_FaixaEtaria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VacinaId] [int] NOT NULL,
	[FaixaEtariaId] [int] NOT NULL,
 CONSTRAINT [PK_Vacina_FaixaEtaria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacinas]    Script Date: 22/12/2022 19:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacinas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NULL,
	[PatogenoId] [int] NOT NULL,
	[FabricanteId] [int] NOT NULL,
	[DataFabricacao] [date] NULL,
	[DataAprovacao] [date] NULL,
	[DosesImunizacao] [int] NULL,
	[PeriodoEntreDoses] [int] NULL,
	[EficaciaComprovada] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Vacinas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Atendimento_Vacinas]  WITH CHECK ADD  CONSTRAINT [FK_Atendimento_Vacinas_Atendimentos] FOREIGN KEY([AtendimentoId])
REFERENCES [dbo].[Atendimentos] ([Id])
GO
ALTER TABLE [dbo].[Atendimento_Vacinas] CHECK CONSTRAINT [FK_Atendimento_Vacinas_Atendimentos]
GO
ALTER TABLE [dbo].[Atendimento_Vacinas]  WITH CHECK ADD  CONSTRAINT [FK_Atendimento_Vacinas_Vacinas] FOREIGN KEY([VacinaId])
REFERENCES [dbo].[Vacinas] ([Id])
GO
ALTER TABLE [dbo].[Atendimento_Vacinas] CHECK CONSTRAINT [FK_Atendimento_Vacinas_Vacinas]
GO
ALTER TABLE [dbo].[Atendimentos]  WITH CHECK ADD  CONSTRAINT [FK_Atendimentos_Paciente_ContraIndicacoes] FOREIGN KEY([PacienteId])
REFERENCES [dbo].[Paciente_ContraIndicacoes] ([Id])
GO
ALTER TABLE [dbo].[Atendimentos] CHECK CONSTRAINT [FK_Atendimentos_Paciente_ContraIndicacoes]
GO
ALTER TABLE [dbo].[Doenca_Sintomas]  WITH CHECK ADD  CONSTRAINT [FK_Doenca_Sintomas_Doencas] FOREIGN KEY([DoencaId])
REFERENCES [dbo].[Doencas] ([Id])
GO
ALTER TABLE [dbo].[Doenca_Sintomas] CHECK CONSTRAINT [FK_Doenca_Sintomas_Doencas]
GO
ALTER TABLE [dbo].[Doenca_Sintomas]  WITH CHECK ADD  CONSTRAINT [FK_Doenca_Sintomas_Sintomas] FOREIGN KEY([SintomaId])
REFERENCES [dbo].[Sintomas] ([Id])
GO
ALTER TABLE [dbo].[Doenca_Sintomas] CHECK CONSTRAINT [FK_Doenca_Sintomas_Sintomas]
GO
ALTER TABLE [dbo].[Doencas]  WITH CHECK ADD  CONSTRAINT [FK_Doencas_Patogenos] FOREIGN KEY([PatogenoId])
REFERENCES [dbo].[Patogenos] ([Id])
GO
ALTER TABLE [dbo].[Doencas] CHECK CONSTRAINT [FK_Doencas_Patogenos]
GO
ALTER TABLE [dbo].[Fabricantes]  WITH CHECK ADD  CONSTRAINT [FK_Fabricantes_Paises] FOREIGN KEY([PaisId])
REFERENCES [dbo].[Paises] ([Id])
GO
ALTER TABLE [dbo].[Fabricantes] CHECK CONSTRAINT [FK_Fabricantes_Paises]
GO
ALTER TABLE [dbo].[Paciente_ContraIndicacoes]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_ContraIndicacoes_Pacientes] FOREIGN KEY([PacienteId])
REFERENCES [dbo].[Pacientes] ([Id])
GO
ALTER TABLE [dbo].[Paciente_ContraIndicacoes] CHECK CONSTRAINT [FK_Paciente_ContraIndicacoes_Pacientes]
GO
ALTER TABLE [dbo].[Vacina_ContraIndicacao]  WITH CHECK ADD  CONSTRAINT [FK_Vacina_ContraIndicacao_ContraIndicacoes] FOREIGN KEY([ContraIndicacaoId])
REFERENCES [dbo].[ContraIndicacoes] ([Id])
GO
ALTER TABLE [dbo].[Vacina_ContraIndicacao] CHECK CONSTRAINT [FK_Vacina_ContraIndicacao_ContraIndicacoes]
GO
ALTER TABLE [dbo].[Vacina_ContraIndicacao]  WITH CHECK ADD  CONSTRAINT [FK_Vacina_ContraIndicacao_Vacinas] FOREIGN KEY([VacinaId])
REFERENCES [dbo].[Vacinas] ([Id])
GO
ALTER TABLE [dbo].[Vacina_ContraIndicacao] CHECK CONSTRAINT [FK_Vacina_ContraIndicacao_Vacinas]
GO
ALTER TABLE [dbo].[Vacina_Doenca]  WITH CHECK ADD  CONSTRAINT [FK_Vacina_Doenca_Doencas] FOREIGN KEY([DoencaId])
REFERENCES [dbo].[Doencas] ([Id])
GO
ALTER TABLE [dbo].[Vacina_Doenca] CHECK CONSTRAINT [FK_Vacina_Doenca_Doencas]
GO
ALTER TABLE [dbo].[Vacina_Doenca]  WITH CHECK ADD  CONSTRAINT [FK_Vacina_Doenca_Vacinas] FOREIGN KEY([VacinaId])
REFERENCES [dbo].[Vacinas] ([Id])
GO
ALTER TABLE [dbo].[Vacina_Doenca] CHECK CONSTRAINT [FK_Vacina_Doenca_Vacinas]
GO
ALTER TABLE [dbo].[Vacina_FaixaEtaria]  WITH CHECK ADD  CONSTRAINT [FK_Vacina_FaixaEtaria_FaixasEtarias] FOREIGN KEY([FaixaEtariaId])
REFERENCES [dbo].[FaixasEtarias] ([Id])
GO
ALTER TABLE [dbo].[Vacina_FaixaEtaria] CHECK CONSTRAINT [FK_Vacina_FaixaEtaria_FaixasEtarias]
GO
ALTER TABLE [dbo].[Vacina_FaixaEtaria]  WITH CHECK ADD  CONSTRAINT [FK_Vacina_FaixaEtaria_Vacinas] FOREIGN KEY([VacinaId])
REFERENCES [dbo].[Vacinas] ([Id])
GO
ALTER TABLE [dbo].[Vacina_FaixaEtaria] CHECK CONSTRAINT [FK_Vacina_FaixaEtaria_Vacinas]
GO
ALTER TABLE [dbo].[Vacinas]  WITH CHECK ADD  CONSTRAINT [FK_Vacinas_Fabricantes] FOREIGN KEY([FabricanteId])
REFERENCES [dbo].[Fabricantes] ([Id])
GO
ALTER TABLE [dbo].[Vacinas] CHECK CONSTRAINT [FK_Vacinas_Fabricantes]
GO
ALTER TABLE [dbo].[Vacinas]  WITH CHECK ADD  CONSTRAINT [FK_Vacinas_TipoImunizacao] FOREIGN KEY([TipoImunizacaoId])
REFERENCES [dbo].[TipoImunizacao] ([Id])
GO
ALTER TABLE [dbo].[Vacinas] CHECK CONSTRAINT [FK_Vacinas_TipoImunizacao]
GO


/*** CRIAÇÃO DE DADOS MESTRES E USUARIO INICIAL **/

---> Inserção usuario Administrador
Insert into Usuario (nome,email,senha) values ('Administrador','admin@smartvac.com','CFA48412EC26236D1AE25CEEB9EAA2BC6CB88432')

---> Inserção Paises
Insert into paises (iso3,nome) values ('SHN','Santa Helena, Ascensão e Tristão da Cunha')
Insert into paises (iso3,nome) values ('ABW','Aruba')
Insert into paises (iso3,nome) values ('AFG','Afeganistão')
Insert into paises (iso3,nome) values ('AGO','Angola')
Insert into paises (iso3,nome) values ('AIA','Anguila')
Insert into paises (iso3,nome) values ('ALB','Albânia')
Insert into paises (iso3,nome) values ('AND','Andorra')
Insert into paises (iso3,nome) values ('ARE','Emirados Árabes Unidos')
Insert into paises (iso3,nome) values ('ARG','Argentina')
Insert into paises (iso3,nome) values ('ARM','Armênia')
Insert into paises (iso3,nome) values ('ASM','Samoa Americana')
Insert into paises (iso3,nome) values ('ATG','Antígua e Barbuda')
Insert into paises (iso3,nome) values ('AUS','Austrália')
Insert into paises (iso3,nome) values ('AUT','Áustria')
Insert into paises (iso3,nome) values ('AZE','Azerbaijão')
Insert into paises (iso3,nome) values ('BDI','Burundi')
Insert into paises (iso3,nome) values ('BEL','Bélgica')
Insert into paises (iso3,nome) values ('BEN','Benin')
Insert into paises (iso3,nome) values ('BES','Países Baixos Caribenhos')
Insert into paises (iso3,nome) values ('BFA','Burkina Faso')
Insert into paises (iso3,nome) values ('BGD','Bangladesh')
Insert into paises (iso3,nome) values ('BGR','Bulgária')
Insert into paises (iso3,nome) values ('BHR','Bahrein')
Insert into paises (iso3,nome) values ('BHS','Bahamas')
Insert into paises (iso3,nome) values ('BIH','Bósnia e Herzegovina')
Insert into paises (iso3,nome) values ('BLR','Belarus')
Insert into paises (iso3,nome) values ('BLZ','Belize')
Insert into paises (iso3,nome) values ('BMU','Bermudas')
Insert into paises (iso3,nome) values ('BOL','Bolívia')
Insert into paises (iso3,nome) values ('BRA','Brasil')
Insert into paises (iso3,nome) values ('BRB','Barbados')
Insert into paises (iso3,nome) values ('BRN','Brunei')
Insert into paises (iso3,nome) values ('BTN','Butão')
Insert into paises (iso3,nome) values ('BWA','Botsuana')
Insert into paises (iso3,nome) values ('CAF','República Centro-Africana')
Insert into paises (iso3,nome) values ('CAN','Canadá')
Insert into paises (iso3,nome) values ('CHE','Suíça')
Insert into paises (iso3,nome) values ('CHL','Chile')
Insert into paises (iso3,nome) values ('CHN','China')
Insert into paises (iso3,nome) values ('CIV','Costa do Marfim')
Insert into paises (iso3,nome) values ('CMR','Camarões')
Insert into paises (iso3,nome) values ('COD','República Democrática do Congo')
Insert into paises (iso3,nome) values ('COG','República do Congo')
Insert into paises (iso3,nome) values ('COK','Ilhas Cook')
Insert into paises (iso3,nome) values ('COL','Colômbia')
Insert into paises (iso3,nome) values ('COM','Comores')
Insert into paises (iso3,nome) values ('CPV','Cabo Verde')
Insert into paises (iso3,nome) values ('CRI','Costa Rica')
Insert into paises (iso3,nome) values ('CUB','Cuba')
Insert into paises (iso3,nome) values ('CUW','Curaçao')
Insert into paises (iso3,nome) values ('CYM','Ilhas Cayman')
Insert into paises (iso3,nome) values ('CYP','Chipre')
Insert into paises (iso3,nome) values ('CZE','Tcheca')
Insert into paises (iso3,nome) values ('DEU','Alemanha')
Insert into paises (iso3,nome) values ('DJI','Djibouti')
Insert into paises (iso3,nome) values ('DMA','Dominica')
Insert into paises (iso3,nome) values ('DNK','Dinamarca')
Insert into paises (iso3,nome) values ('DOM','República Dominicana')
Insert into paises (iso3,nome) values ('DZA','Argélia')
Insert into paises (iso3,nome) values ('ECU','Equador')
Insert into paises (iso3,nome) values ('EGY','Egito')
Insert into paises (iso3,nome) values ('ESP','Espanha')
Insert into paises (iso3,nome) values ('EST','Estônia')
Insert into paises (iso3,nome) values ('ETH','Etiópia')
Insert into paises (iso3,nome) values ('FIN','Finlândia')
Insert into paises (iso3,nome) values ('FJI','Fiji')
Insert into paises (iso3,nome) values ('FLK','Ilhas Malvinas')
Insert into paises (iso3,nome) values ('FRA','França')
Insert into paises (iso3,nome) values ('FRO','Ilhas Faroe')
Insert into paises (iso3,nome) values ('FSM','Estados Federados da Micronésia')
Insert into paises (iso3,nome) values ('GAB','Gabão')
Insert into paises (iso3,nome) values ('GBR','Reino Unido')
Insert into paises (iso3,nome) values ('GEO','Geórgia')
Insert into paises (iso3,nome) values ('GGY','Guernsey')
Insert into paises (iso3,nome) values ('GHA','Gana')
Insert into paises (iso3,nome) values ('GIB','Gibraltar')
Insert into paises (iso3,nome) values ('GIN','Guiné')
Insert into paises (iso3,nome) values ('GLP','Guadalupe')
Insert into paises (iso3,nome) values ('GMB','Gâmbia')
Insert into paises (iso3,nome) values ('GNB','Guiné-Bissau')
Insert into paises (iso3,nome) values ('GNQ','Guiné Equatorial')
Insert into paises (iso3,nome) values ('GRC','Grécia')
Insert into paises (iso3,nome) values ('GRD','Grenada')
Insert into paises (iso3,nome) values ('GRL','Gronelândia')
Insert into paises (iso3,nome) values ('GTM','Guatemala')
Insert into paises (iso3,nome) values ('GUF','Guiana Francesa')
Insert into paises (iso3,nome) values ('GUM','Guam')
Insert into paises (iso3,nome) values ('GUY','Guiana')
Insert into paises (iso3,nome) values ('HND','Honduras')
Insert into paises (iso3,nome) values ('HRV','Croácia')
Insert into paises (iso3,nome) values ('HTI','Haiti')
Insert into paises (iso3,nome) values ('HUN','Hungria')
Insert into paises (iso3,nome) values ('IDN','Indonésia')
Insert into paises (iso3,nome) values ('IMN','Ilha de Man')
Insert into paises (iso3,nome) values ('IND','Índia')
Insert into paises (iso3,nome) values ('IRL','Irlanda')
Insert into paises (iso3,nome) values ('IRN','Irã')
Insert into paises (iso3,nome) values ('IRQ','Iraque')
Insert into paises (iso3,nome) values ('ISL','Islândia')
Insert into paises (iso3,nome) values ('ISR','Israel')
Insert into paises (iso3,nome) values ('ITA','Itália')
Insert into paises (iso3,nome) values ('JAM','Jamaica')
Insert into paises (iso3,nome) values ('JEY','Jersey')
Insert into paises (iso3,nome) values ('JOR','Jordânia')
Insert into paises (iso3,nome) values ('JPN','Japão')
Insert into paises (iso3,nome) values ('KAZ','Cazaquistão')
Insert into paises (iso3,nome) values ('KEN','Quênia')
Insert into paises (iso3,nome) values ('KGZ','Quirguizistão')
Insert into paises (iso3,nome) values ('KHM','Camboja')
Insert into paises (iso3,nome) values ('KIR','Kiribati')
Insert into paises (iso3,nome) values ('KNA','St. Kitts e Nevis')
Insert into paises (iso3,nome) values ('KOR','Coréia do Sul')
Insert into paises (iso3,nome) values ('KWT','Kuwait')
Insert into paises (iso3,nome) values ('LAO','Laos')
Insert into paises (iso3,nome) values ('LBN','Líbano')
Insert into paises (iso3,nome) values ('LBR','Libéria')
Insert into paises (iso3,nome) values ('LBY','Líbia')
Insert into paises (iso3,nome) values ('LCA','Santa Lúcia')
Insert into paises (iso3,nome) values ('LIE','Liechtenstein')
Insert into paises (iso3,nome) values ('LKA','Sri Lanka')
Insert into paises (iso3,nome) values ('LSO','Lesotho')
Insert into paises (iso3,nome) values ('LTU','Lituânia')
Insert into paises (iso3,nome) values ('LUX','Luxemburgo')
Insert into paises (iso3,nome) values ('LVA','Letônia')
Insert into paises (iso3,nome) values ('MAR','Marrocos')
Insert into paises (iso3,nome) values ('MCO','Principado de Mônaco')
Insert into paises (iso3,nome) values ('MDA','Moldávia')
Insert into paises (iso3,nome) values ('MDG','Madagascar')
Insert into paises (iso3,nome) values ('MDV','Maldivas')
Insert into paises (iso3,nome) values ('MEX','México')
Insert into paises (iso3,nome) values ('MHL','Ilhas Marshall')
Insert into paises (iso3,nome) values ('MKD','Norte da Macedônia')
Insert into paises (iso3,nome) values ('MLI','Mali')
Insert into paises (iso3,nome) values ('MLT','Malta')
Insert into paises (iso3,nome) values ('MMR','Mianmar')
Insert into paises (iso3,nome) values ('MNE','Montenegro')
Insert into paises (iso3,nome) values ('MNG','Mongólia')
Insert into paises (iso3,nome) values ('MNP','Ilhas Marianas do Norte')
Insert into paises (iso3,nome) values ('MOZ','Moçambique')
Insert into paises (iso3,nome) values ('MRT','Mauritânia')
Insert into paises (iso3,nome) values ('MSR','Montserrat')
Insert into paises (iso3,nome) values ('MTQ','Martinica')
Insert into paises (iso3,nome) values ('MUS','Maurício')
Insert into paises (iso3,nome) values ('MWI','Malauí')
Insert into paises (iso3,nome) values ('MYS','Malásia')
Insert into paises (iso3,nome) values ('NAM','Namíbia')
Insert into paises (iso3,nome) values ('NCL','Nova Caledônia')
Insert into paises (iso3,nome) values ('NER','Níger')
Insert into paises (iso3,nome) values ('NGA','Nigéria')
Insert into paises (iso3,nome) values ('NIC','Nicarágua')
Insert into paises (iso3,nome) values ('NIU','Niue')
Insert into paises (iso3,nome) values ('NLD','Países Baixos')
Insert into paises (iso3,nome) values ('NOR','Noruega')
Insert into paises (iso3,nome) values ('NPL','Nepal')
Insert into paises (iso3,nome) values ('NRU','Nauru')
Insert into paises (iso3,nome) values ('NZL','Nova Zelândia')
Insert into paises (iso3,nome) values ('OMN','Omã')
Insert into paises (iso3,nome) values ('PAK','Paquistão')
Insert into paises (iso3,nome) values ('PAN','Panamá')
Insert into paises (iso3,nome) values ('PCN','Ilhas Pitcairn')
Insert into paises (iso3,nome) values ('PER','Peru')
Insert into paises (iso3,nome) values ('PHL','Filipinas')
Insert into paises (iso3,nome) values ('PLW','Palau')
Insert into paises (iso3,nome) values ('PNG','Papua Nova Guiné')
Insert into paises (iso3,nome) values ('POL','Polônia')
Insert into paises (iso3,nome) values ('PRI','Porto Rico')
Insert into paises (iso3,nome) values ('PRT','Portugal')
Insert into paises (iso3,nome) values ('PRY','Paraguai')
Insert into paises (iso3,nome) values ('PSE','Palestina')
Insert into paises (iso3,nome) values ('PYF','Polinésia Francesa')
Insert into paises (iso3,nome) values ('QAT','Qatar')
Insert into paises (iso3,nome) values ('ROU','Romênia')
Insert into paises (iso3,nome) values ('RUS','Rússia')
Insert into paises (iso3,nome) values ('RWA','Ruanda')
Insert into paises (iso3,nome) values ('SAU','Arábia Saudita')
Insert into paises (iso3,nome) values ('SDN','Sudão')
Insert into paises (iso3,nome) values ('SEN','Senegal')
Insert into paises (iso3,nome) values ('SGP','Cingapura')
Insert into paises (iso3,nome) values ('SLB','Ilhas Salomão')
Insert into paises (iso3,nome) values ('SLE','Serra Leoa')
Insert into paises (iso3,nome) values ('SLV','El Salvador')
Insert into paises (iso3,nome) values ('SMR','São Marino')
Insert into paises (iso3,nome) values ('SOM','Somália')
Insert into paises (iso3,nome) values ('SRB','Sérvia')
Insert into paises (iso3,nome) values ('SSD','Sudão do Sul')
Insert into paises (iso3,nome) values ('STP','São Tomé e Príncipe')
Insert into paises (iso3,nome) values ('SUR','Suriname')
Insert into paises (iso3,nome) values ('SVK','Eslováquia')
Insert into paises (iso3,nome) values ('SVN','Eslovênia')
Insert into paises (iso3,nome) values ('SWE','Suécia')
Insert into paises (iso3,nome) values ('SWZ','Eswatini')
Insert into paises (iso3,nome) values ('SXM','Sint Maarten')
Insert into paises (iso3,nome) values ('SYC','Seychelles')
Insert into paises (iso3,nome) values ('SYR','Síria')
Insert into paises (iso3,nome) values ('TCA','Ilhas Turcas e Caicos')
Insert into paises (iso3,nome) values ('TCD','Chade')
Insert into paises (iso3,nome) values ('TGO','Togo')
Insert into paises (iso3,nome) values ('THA','Tailândia')
Insert into paises (iso3,nome) values ('TJK','Tajiquistão')
Insert into paises (iso3,nome) values ('TKL','Tokelau')
Insert into paises (iso3,nome) values ('TKM','Turcomenistão')
Insert into paises (iso3,nome) values ('TLS','Timor Leste')
Insert into paises (iso3,nome) values ('TON','Tonga')
Insert into paises (iso3,nome) values ('TTO','Trinidad e Tobago')
Insert into paises (iso3,nome) values ('TUN','Tunísia')
Insert into paises (iso3,nome) values ('TUR','Turquia')
Insert into paises (iso3,nome) values ('TUV','Tuvalu')
Insert into paises (iso3,nome) values ('TZA','Tanzânia')
Insert into paises (iso3,nome) values ('UGA','Uganda')
Insert into paises (iso3,nome) values ('UKR','Ucrânia')
Insert into paises (iso3,nome) values ('URY','Uruguai')
Insert into paises (iso3,nome) values ('USA','Estados Unidos da América')
Insert into paises (iso3,nome) values ('UZB','Uzbequistão')
Insert into paises (iso3,nome) values ('VCT','São Vicente e as Granadinas')
Insert into paises (iso3,nome) values ('VEN','Venezuela')
Insert into paises (iso3,nome) values ('VGB','Ilhas Virgens (Reino Unido)')
Insert into paises (iso3,nome) values ('VNM','Vietnã')
Insert into paises (iso3,nome) values ('VUT','Vanuatu')
Insert into paises (iso3,nome) values ('WLF','Wallis e Futuna')
Insert into paises (iso3,nome) values ('WSM','Samoa')
Insert into paises (iso3,nome) values ('XKX','Kosovo')
Insert into paises (iso3,nome) values ('YEM','Iêmen')
Insert into paises (iso3,nome) values ('ZAF','África do Sul')
Insert into paises (iso3,nome) values ('ZMB','Zâmbia')
Insert into paises (iso3,nome) values ('ZWE','Zimbábue')

---> Inserção Patogenos
insert into Patogenos values ('Chlamydophila pneumoniae')
insert into Patogenos values ('Clostridium tetani')
insert into Patogenos values ('Coronavirus')
insert into Patogenos values ('Flavivirus sp')
insert into Patogenos values ('Mycobacterium tuberculosis')
insert into Patogenos values ('Hepatovirus A')
insert into Patogenos values ('Hepatovirus B')
insert into Patogenos values ('Hepatovirus C')
insert into Patogenos values ('Hepatovirus D')
insert into Patogenos values ('Hepatovirus E')
insert into Patogenos values ('Hepatovirus F')
insert into Patogenos values ('Influenzavirus A, B e C')
insert into Patogenos values ('Mycobacterium tuberculosis')
insert into Patogenos values ('Morbillivirus sp.')
insert into Patogenos values ('Rotavirus sp')
insert into Patogenos values ('Enterovirus poliovirus')
insert into Patogenos values ('Vírus do papiloma humano - HPV')