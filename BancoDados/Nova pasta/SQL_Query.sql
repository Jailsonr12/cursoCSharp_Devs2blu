select id,
		nome,
        data_nascimento,
        Idade,
        status
 from pessoa
;
 select id,
		id_pessoa,
        login,
        senha,
        status
 from usuario
 ;

SELECT p.id as codigo_pessoa,
	u.id as codigo_usuario,
	p.nome,
	u.login,
    u.senha,
    p.data_nascimento as nascimento,
    p.Idade,
    p.status as situacao_pessoa,
    u.status as status_usuario
FROM pessoa as p
JOIN usuario as u
	ON (p.id = u.id_pessoa);
;

SELECT * 
FROM pessoa
WHERE data_nascimento < '1998-01-01' 
;  
    
