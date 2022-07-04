-- CREATE DATABASE utiroda;
-- USE utiroda;

CREATE TABLE idegenvezeto (
  i_kod INT PRIMARY KEY,
  nev VARCHAR(100));

CREATE TABLE utvonal (
  ut_kod INT PRIMARY KEY,
  hova VARCHAR(100),
  tavolsag INT);
 
CREATE TABLE szallas(
  sz_kod INT PRIMARY KEY,
  nev VARCHAR(100),
  cim VARCHAR(100),
  ferohely INT);

CREATE TABLE tura(
  t_kod INT PRIMARY KEY,
  kezdet DATE,
  vege DATE,
  vezeto INT FOREIGN KEY REFERENCES idegenvezeto(i_kod),
  szallas INT FOREIGN KEY REFERENCES szallas(sz_kod),
  utvonal INT FOREIGN KEY REFERENCES utvonal(ut_kod),
  ar INT);
  
CREATE TABLE utas(
  u_kod INT PRIMARY KEY,
  nev VARCHAR(100),
  cim VARCHAR(100),
  jelentkezik INT FOREIGN KEY REFERENCES tura(t_kod));

INSERT INTO idegenvezeto VALUES
(1, 'Kiss Pál'),
(2, 'Szabó Katalin'),
(3, 'Nagy Győző'),
(4, 'Virág Olga'),
(5, 'Kovács Tamás'),
(6, 'Hegedűs Anna');

INSERT INTO utvonal VALUES
(1, 'Szombathely', 230),
(2, 'Pécs', 215),
(3, 'Balatonfüred', 130),
(4, 'Szeged', 175),
(5, 'Debrecen', 230),
(6, 'Kecskemét', 90),
(7, 'Gyula', 240),
(8, 'Hajdúszoboszló', 245),
(9, 'Győr', 125),
(10, 'Sopron', 210),
(11, 'Eger', 130),
(12, 'Miskolc', 185),
(13, 'Veszprém', 122),
(14, 'Kőszeg', 220),
(15, 'Békéscsaba', 215),
(16, 'Zalaegerszeg', 228);


INSERT INTO szallas VALUES
(1, 'Napsugár Vendégház', 'Balatonfüred', 25),
(2, 'Rózsa Panzó', 'Balatonfüred', 120),
(3, 'Vadvirág Apartman', 'Békéscsaba', 30),
(4, 'Sport Hotel', 'Békéscsaba', 45),
(5, 'Centrum Panzió', 'Debrecen', 45),
(6, 'Kikelet Szálló', 'Debrecen', 200),
(7, 'Szent Anna Vendégház', 'Eger', 22),
(8, 'Pipacs Szálloda', 'Eger', 70),
(9, 'Ibolya Apartman', 'Győr', 20),
(10, 'Kökörcsin Hotel', 'Győr', 85),
(11, 'Vár Panzió', 'Gyula', 40),
(12, 'Almafa Apartman', 'Gyula', 50),
(13, 'Kaktusz Panzió', 'Hajdúszoboszló', 20),
(14, 'Délibáb Hotel', 'Hajdúszoboszló', 78),
(15, 'Hóvirág Hotel', 'Kecskemét', 30),
(16, 'Tulipán Szálló', 'Kecskemét', 45),
(17, 'Liliom Panzió', 'Kőszeg', 60),
(18, 'Magnólia Hotel', 'Kőszeg', 90),
(19, 'Szegfű Szálló', 'Miskolc', 34),
(20, 'Muskátli Hotel', 'Miskolc', 68),
(21, 'Boglárka Apartman', 'Pécs', 50),
(22, 'Mandula Hotel', 'Pécs', 100),
(23, 'Füge Vendégház', 'Sopron', 35),
(24, 'Körte Hotel', 'Sopron', 70),
(25, 'Paprika Panzió', 'Szeged', 45),
(26, 'Dóm Hotel', 'Szeged', 90),
(27, 'Szilva Szálló', 'Veszprém', 20),
(28, 'Eper Apartman', 'Veszprém', 45),
(29, 'Zala Panzió', 'Zalaegerszeg', 40),
(30, 'Egér Hotel', 'Zalaegerszeg', 72);

INSERT INTO tura VALUES
(1, '2015-08-15', '2015-08-25', 2, 27, 13, 70000),
(2, '2015-08-26', '2015-08-01', 1, 23, 10, 64000),
(3, '2015-09-27', '2015-09-03', 4, 3, 15, 89000),
(4, '2015-09-27', '2015-09-02', 5, 29, 16, 61000),
(5, '2015-10-15', '2015-10-17', 3, 25, 4, 30000),
(6, '2015-10-05', '2015-10-10', 6, 15, 6, 56000),
(7, '2015-11-07', '2015-11-13', 1, 11, 7, 67000),
(8, '2015-11-24', '2015-11-01', 2, 9,  9, 99000);

INSERT INTO utas VALUES
(1, 'Nagy Istók', 'Velence', 7),
(2, 'Balla Béla', 'Makád', 3),
(3, 'Ottó Áron', 'Budapest', 8),
(4, 'Nagy Eszter', 'Budapest', 1),
(5, 'Kiss Dalma', 'Debrecen', 6),
(6, 'Hirte Lenke', 'Szeged', 1),
(7, 'Nemfá Zoltán', 'Érd', 1),
(8, 'Mar Tamás', 'Paks', 1),
(9, 'Csin Csilla', 'Vác', 3),
(10, 'Nap Ernő', 'Gödöllő', 7),
(11, 'Agyalá Gyula', 'Budapest', 7),
(12, 'Kiss Balázs', 'Siófok', 5),
(13, 'Bíró László', 'Budapest', 3),
(14, 'Kerekes Anna', 'Göd', 7),
(15, 'Farkas Csaba', 'Ráckeve', 6),
(16, 'Varga Kata', 'Tököl', 6),
(17, 'Nagy László', 'Dömsöd', 6),
(18, 'Kiss Elek', 'Budapest', 1),
(19, 'Kincses Nóra', 'Visegrád', 1),
(20, 'Egyed Andrea', 'Esztergom', 4),
(21, 'Laki Mária', 'Szigethalom', 7),
(23, 'Balla Béla', 'Makád', 1);
