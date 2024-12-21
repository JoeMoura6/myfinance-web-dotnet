-- Inserindo 10 registros na tabela PLANOCONTA
INSERT INTO PLANOCONTA (nome, tipo) VALUES
('Conta de Energia', 'D'),
('Sal�rio Funcion�rios', 'R'),
('Aluguel', 'D'),
('Venda de Produtos', 'R'),
('Manuten��o de Equipamentos', 'D'),
('Investimentos', 'R'),
('Materiais de Escrit�rio', 'D'),
('Consultoria', 'R'),
('Servi�os de Limpeza', 'D'),
('Receita de Servi�os', 'R');


-- Inserindo 10 registros na tabela TRANSACAO com refer�ncias � PLANOCONTA
INSERT INTO TRANSACAO (data, valor, historico, tipo, planocontaid) VALUES
('2024-01-05T14:30:00', 500.00, 'Pagamento de conta de energia', 'D', 1),
('2024-01-10T09:00:00', 3000.00, 'Recebimento de sal�rio', 'R', 2),
('2024-01-15T12:00:00', 2000.00, 'Pagamento de aluguel do escrit�rio', 'D', 3),
('2024-01-20T16:45:00', 4500.00, 'Venda de produtos eletr�nicos', 'R', 4),
('2024-02-01T10:15:00', 600.00, 'Manuten��o de impressora', 'D', 5),
('2024-02-05T11:30:00', 1000.00, 'Recebimento de investimentos', 'R', 6),
('2024-02-10T08:45:00', 250.00, 'Compra de materiais de escrit�rio', 'D', 7),
('2024-02-15T14:00:00', 1500.00, 'Recebimento de consultoria', 'R', 8),
('2024-02-20T17:15:00', 400.00, 'Pagamento de servi�os de limpeza', 'D', 9),
('2024-02-25T15:30:00', 2000.00, 'Receita de presta��o de servi�os', 'R', 10);


select * from TRANSACAO where tipo = 'D'