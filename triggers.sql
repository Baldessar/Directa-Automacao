CREATE OR REPLACE TRIGGER trigger_linha
BEFORE INSERT ON linha
FOR EACH ROW
BEGIN
	--
	IF :NEW.seq_linha IS NULL THEN
		SELECT seq_linha.NEXTVAL
		  INTO :NEW.seq_linha
          FROM DUAL;
	END IF;
	--
END;
/

CREATE OR REPLACE TRIGGER trigger_producao
BEFORE INSERT ON producao
FOR EACH ROW
BEGIN
	--
	IF :NEW.seq_producao IS NULL THEN
		SELECT seq_producao.NEXTVAL
		  INTO :NEW.seq_producao
          FROM DUAL;
	END IF;
	--
END;
/

CREATE OR REPLACE TRIGGER trigger_producao_maior
BEFORE INSERT ON producao_maior
FOR EACH ROW
BEGIN
	--
	IF :NEW.seq_prod_maior IS NULL THEN
		SELECT seq_producao_maior.NEXTVAL
		  INTO :NEW.seq_prod_maior
          FROM DUAL;
	END IF;
	--
END;
/
