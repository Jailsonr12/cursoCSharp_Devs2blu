UPDATE pessoa
	SET data_nascimento = '1998-02-23',
    idade = 34
WHERE id IN (1,7,8,9)
;

UPDATE pessoa
	SET data_nascimento = '1995-05-15',
    idade = 27
WHERE id IN (10,11,12)
;