﻿create procedure SpInserirProduto
		@Nome nvarchar(50),
		@Preco decimal(18,2)
		as
		begin
		insert into Produto(Nome, Preco, DataCadastro)
		values(@Nome, @Preco, GetDate())
		end
		go

create procedure SpAtualizarProduto
		@IdProduto integer,
		@Nome nvarchar(50),
		@Preco decimal(18,2)
		as
		begin
		update Produto
		set Nome = @Nome, Preco = @Preco
		where IdProduto = @IdProduto
		end
		go

create procedure SpExcluirProduto
		@IdProduto integer
		as
		begin
		delete from Produto
		where IdProduto = @IdProduto
		end
		go

		create procedure SpConsultarProdutos
		as
		begin
			select * from Produto
		end
		go