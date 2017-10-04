REATE OR REPLACE PROCEDURE p_delete_media IS
  CURSOR pega_delete IS
    SELECT * FROM producao;
    media INT := 0;
  BEGIN
    FOR item IN pega_delete LOOP
      media := f_media_peso;
      IF item.num_peso < media THEN
       DELETE producao WHERE seq_producao = item.seq_producao;
      END IF;
    END LOOP;
    COMMIT;
END;


CREATE OR REPLACE PROCEDURE p_move_linha(linha_prod INT) AS
  CURSOR select_copia IS
    SELECT * FROM producao WHERE cod_linha = linha_prod AND flg_lido = 'N'; --AND peso > (SELECT Max(peso) FROM producao);
    lido CHAR(1);
    media FLOAT := 0;
    id INT := 0;
    BEGIN
      SELECT Round(Avg(num_peso),2) INTO media FROM producao;
      FOR item IN select_copia LOOP
        --SELECT item.seq_producao INTO id FROM producao;
        --SELECT item.flag_lido INTO lido FROM producao;
        lido := item.flg_lido;
        UPDATE producao SET flg_lido = 'S' WHERE seq_producao = item.seq_producao;
        IF item.num_peso > media THEN
          INSERT INTO producao_maior(nom_produto,cod_linha,num_peso,num_serie)VALUES(item.nom_produto,item.cod_linha,item.num_peso,item.num_serie);
        END IF;
      END LOOP;
  COMMIT;
  END;


CREATE OR REPLACE PROCEDURE p_registro_peso AS
    qtd INT := 0;
    med number := 0;
    maxi INT := 0;
    mini INT :=0;
    soma INT := 0;
    first VARCHAR(100);
    last VARCHAR(100);
  BEGIN
    SELECT Count (*) INTO qtd FROM producao;
    SELECT Round (Avg(num_peso),3) INTO med FROM producao;
    SELECT Max(num_peso) INTO maxi FROM producao;
    SELECT Min(num_peso) INTO mini FROM producao;
    SELECT nom_produto INTO first FROM(SELECT nom_produto FROM producao ORDER BY nom_produto ASC) WHERE ROWNUM = 1;
    SELECT nom_produto INTO last FROM(SELECT nom_produto FROM producao ORDER BY nom_produto DESC) WHERE ROWNUM = 1;
    SELECT Sum(num_peso) INTO soma FROM(SELECT * FROM producao ORDER BY num_peso DESC) WHERE ROWNUM <4;
    INSERT INTO registro(dat_data,qtd_itens,num_media,maximo,minimo,somatop,nom_primeiro,nom_ultimo)VALUES (SYSDATE,qtd,med,maxi,mini,soma,first,last);
    COMMIT;
  END;


CREATE OR REPLACE PROCEDURE p_teste(qtd int) AS
    i INT := 0;
    random INT := 0;
BEGIN
 LOOP
 random := Round(DBMS_RANDOM.Value(1,5),0);
 INSERT INTO producao(nom_produto,cod_linha,num_peso,num_serie) VALUES(dbms_random.string('L',7),random,DBMS_RANDOM.RANDOM,DBMS_RANDOM.RANDOM);
 i := i+1;
 EXIT WHEN i > qtd;

END LOOP;
COMMIT;
END;












