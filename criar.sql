CREATE TABLE linha (
  seq_linha INTEGER       NOT NULL,
  cod_linha VARCHAR2(10)  NOT NULL primary key,
  des_linha VARCHAR2(50) NULL
)

CREATE TABLE producao (
  seq_producao number(10)    NOT NULL,
  nom_produto  VARCHAR2(20)  NOT NULL,
  cod_linha    VARCHAR2(10)  NOT NULL,
  num_peso     number(20,10) NOT NULL,
  num_serie    number(20,10) NOT NULL,
  flg_lido     char(1) DEFAULT 'N' NULL,
  CONSTRAINT pk_producao primary key(produto,numero_serie),
  CONSTRAINT fk_cod_linha_prod FOREIGN KEY(cod_linha) references linha(cod_linha)
)

CREATE TABLE producao_maior (
  seq_producao_maior number(10) NOT NULL,
  nom_produto  VARCHAR2(20)  NOT NULL,
  cod_linha    VARCHAR2(10)  NOT NULL,
  num_peso     number(20,10) NOT NULL,
  num_serie    number(20,10) NOT NULL,
  CONSTRAINT pk_producao_maior primary key(produto,numero_serie),
  CONSTRAINT fk_cod_linha_prod_maior FOREIGN KEY(cod_linha) references linha(cod_linha)
)

CREATE TABLE registro (
  qtd_itens  number(5)     NOT NULL,
  num_media  number(20,10) NOT NULL,
  maximo     number(20,10) NOT NULL,
  minimo     number(20,10) NOT NULL,
  somatop    number(20,10) NOT NULL,
  nom_primeiro VARCHAR2(20) NOT NULL,
  nom_ultimo   VARCHAR2(20) NOT NULL,
  dat_data     DATE          NULL
)

