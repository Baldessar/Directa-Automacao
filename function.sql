CREATE OR REPLACE FUNCTION F_media_peso
  RETURN NUMBER
  IS
  i NUMBER;
  BEGIN
  SELECT Avg(num_peso) INTO i FROM producao;
  RETURN i;
END;
