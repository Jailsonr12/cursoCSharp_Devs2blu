INSERT INTO pessoa(nome,
                    data_nascimento,
                    Idade,
                    status)
VALUES ('Meninim Maluquim','2005-09-01',17,0);

/*Delete Simples*/

DELETE FROM pessoa
WHERE id = 21
;
/*Delete SUBQUERY*/

DELETE FROM pessoa
WHERE id = (SELECT p2.id FROM pessoa as p2 order by p2.id desc limit 1)
;