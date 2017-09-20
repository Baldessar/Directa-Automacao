CREATE OR REPLACE PROCEDURE delete_media IS
  CURSOR pega_delete IS
    SELECT * FROM producao;
    media INT := 0;
  BEGIN
    FOR item IN pega_delete LOOP
      media := media_peso;
      IF item.peso < media THEN
       DELETE producao WHERE seq_producao = item.seq_producao;
      END IF;
    END LOOP;
    COMMIT;
END;


CREATE OR REPLACE PROCEDURE move_linha(linha_prod INT) AS
  CURSOR select_copia IS
    SELECT * FROM producao WHERE cod_linha = linha_prod AND flag_lido = 'N'; --AND peso > (SELECT Max(peso) FROM producao);
    lido CHAR(1);
    media FLOAT := 0;
    id INT := 0;
    BEGIN
      SELECT Round(Avg(peso),2) INTO media FROM producao;
      FOR item IN select_copia LOOP
        --SELECT item.seq_producao INTO id FROM producao;
        --SELECT item.flag_lido INTO lido FROM producao;
        lido := item.flag_lido;
        UPDATE producao SET flag_lido = 'S' WHERE seq_producao = item.seq_producao;
        IF item.peso > media THEN
          INSERT INTO producao_maior(produto,cod_linha,peso,numero_serie)VALUES(item.produto,item.cod_linha,item.peso,item.numero_serie);
        END IF;
      END LOOP;
  COMMIT;
  END;


CREATE OR REPLACE PROCEDURE registro_peso AS
    qtd INT := 0;
    med number := 0;
    maxi INT := 0;
    mini INT :=0;
    soma INT := 0;
    first VARCHAR(100);
    last VARCHAR(100);
  BEGIN
    SELECT Count (*) INTO qtd FROM producao;
    SELECT Round (Avg(peso),3) INTO med FROM producao;
    SELECT Max(peso) INTO maxi FROM producao;
    SELECT Min(peso) INTO mini FROM producao;
    SELECT produto INTO first FROM(SELECT produto FROM producao ORDER BY produto ASC) WHERE ROWNUM = 1;
    SELECT produto INTO last FROM(SELECT produto FROM producao ORDER BY produto DESC) WHERE ROWNUM = 1;
    SELECT Sum(peso) INTO soma FROM(SELECT * FROM producao ORDER BY peso DESC) WHERE ROWNUM <4;
    INSERT INTO registro(data,quantidade,media,maximo,minimo,somatop,primeiro,ultimo)VALUES (SYSDATE,qtd,med,maxi,mini,soma,first,last);
    COMMIT;
  END;


CREATE OR REPLACE PROCEDURE teste(qtd int) AS
    i INT := 0;
    random INT := 0;
BEGIN
 LOOP
 random := Round(DBMS_RANDOM.Value(1,5),0);
 INSERT INTO producao(produto,cod_linha,peso,numero_serie) VALUES(dbms_random.string('L',7),random,DBMS_RANDOM.RANDOM,DBMS_RANDOM.RANDOM);
 i := i+1;
 EXIT WHEN i > qtd;

END LOOP;
END;











