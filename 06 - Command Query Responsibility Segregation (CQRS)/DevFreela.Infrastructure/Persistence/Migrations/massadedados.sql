-- ===========================================
-- POPULANDO TABELAS DO BANCO DEVFREELA
-- ===========================================

-- 1️⃣ Tabela Users
INSERT INTO Users (FullName, Email, BirthDate, CreatedAt, Active)
VALUES
('Alice Silva', 'alice.silva@email.com', '1990-05-15', GETDATE(), 1),
('Bruno Souza', 'bruno.souza@email.com', '1985-10-22', GETDATE(), 1),
('Carla Mendes', 'carla.mendes@email.com', '1992-07-30', GETDATE(), 1),
('Diego Lima', 'diego.lima@email.com', '1988-03-12', GETDATE(), 1),
('Eva Costa', 'eva.costa@email.com', '1995-01-25', GETDATE(), 1);

-- 2️⃣ Tabela Skills
INSERT INTO Skills (Description, CreatedAt)
VALUES
('C#', GETDATE()),
('JavaScript', GETDATE()),
('SQL Server', GETDATE()),
('Python', GETDATE()),
('React', GETDATE());

-- 3️⃣ Tabela UserSkills (relacionando usuários e skills)
INSERT INTO UserSkills (IdUser, IdSkill, SkillId)
VALUES
(1, 1, 1), -- Alice: C#
(1, 2, 2), -- Alice: JavaScript
(2, 3, 3), -- Bruno: SQL Server
(2, 4, 4), -- Bruno: Python
(3, 5, 5), -- Carla: React
(4, 1, 1), -- Diego: C#
(4, 5, 5), -- Diego: React
(5, 2, 2), -- Eva: JavaScript
(5, 4, 4); -- Eva: Python

-- 4️⃣ Tabela Projects
INSERT INTO Projects (Title, Description, IdClient, IdFreelancer, TotalCost, CreatedAt, StartedAt, FinishedAt, Status)
VALUES
('Sistema de Vendas', 'Desenvolvimento de um sistema de vendas online', 1, 2, 15000.00, GETDATE(), GETDATE(), NULL, 1),
('App Mobile', 'Aplicativo mobile para Android e iOS', 3, 4, 20000.00, GETDATE(), GETDATE(), NULL, 1),
('Website Institucional', 'Criação de website institucional para empresa', 5, 1, 8000.00, GETDATE(), GETDATE(), NULL, 2),
('Plataforma E-Learning', 'Desenvolvimento de plataforma de cursos online', 2, 3, 18000.00, GETDATE(), GETDATE(), NULL, 1),
('Sistema Financeiro', 'Sistema para gestão financeira corporativa', 4, 5, 22000.00, GETDATE(), GETDATE(), NULL, 0);
