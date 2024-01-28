-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 14, 2024 at 11:17 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `filmrent`
--

-- --------------------------------------------------------

--
-- Table structure for table `film`
--

CREATE TABLE `film` (
  `id` int(11) NOT NULL,
  `naziv` varchar(100) NOT NULL,
  `godizdanja` int(11) NOT NULL,
  `trajanje` int(11) NOT NULL,
  `zemljaporekla` varchar(40) NOT NULL,
  `radnja` mediumtext NOT NULL,
  `ocena` float NOT NULL,
  `kategorija` varchar(50) NOT NULL,
  `slika` varchar(255) NOT NULL,
  `slika2` varchar(255) NOT NULL,
  `cena` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `film`
--

INSERT INTO `film` (`id`, `naziv`, `godizdanja`, `trajanje`, `zemljaporekla`, `radnja`, `ocena`, `kategorija`, `slika`, `slika2`, `cena`) VALUES
(2, 'Zack Snyder\'s Justice League', 2022, 242, 'USA', 'Odlučan da obezbedi da Supermenova konačna žrtva nije uzaludna, Brus Vejn povezuje snage sa Dajanom Prins sa planovima da regrutuje tim metaljudi da zaštiti svet od približavanja pretnje katastrofalnih razmera. Zadatak se pokazao težim nego što je Brus zamišljao, jer svaki od regruta mora da se suoči sa demonima sopstvene prošlosti kako bi prevazišao ono što ih je sputavalo, dozvoljavajući im da se udruže, konačno formirajući ligu heroja bez presedana. Sada ujedinjeni, Betmen, Vonder Voman, Akuaman, Ciborg i The Flash možda će biti prekasno da spasu planetu od Steppenvolfa, DeSaada i Darkseida i njihovih strašnih namera.', 8, 'Akcija Avantura Fantastika', 'imgs/JL.png', 'imgs/slike/JL.jpg', 10),
(3, 'Avengers: Endgame', 2019, 181, 'USA', 'Ogromna devastacija koju je izazvao ludi Titan Tanos ostavila je u šoku ono što je ostalo od Osvetnika. Neko vreme se čini da je svaka nada izgubljena... dok se ne ukaže prilika da se šteta preokrene. Sada, tim se mora još jednom okupiti i učiniti sve što je potrebno da obnovi univerzum i vrati one koje su izgubili.', 8.4, 'Akcija Avantura Naucna-Fantastika', 'imgs/AEG.jpg', 'imgs/slike/AEG.jpg', 10),
(4, 'Avengers: Infinity War', 2018, 149, 'USA', 'Ludi titan Tanos (Džoš Brolin) u ovom filmu počinje svoj lov na najmoćnije objekte u univerzumu, Beskonačno kamenje. Sa Svemirskim kamenom, koji je dao Loki, i Kamenom moći, Tanos šalje, Cull Obsidian da preuzme Kamen vremena od Doktora Strejndža, šalje Proksimu Midnight i Corvus Glaivea da dohvate Kamen uma iz Visiona. U međuvremenu, Toni Stark se sastaje sa Brusom Benerom i čarobnjacima Doktorom Strejndžom i Vongom. Uz pomoć Pitera Parkera/Spajdermena , Stark i Strejndž udružuju snage i pristaju da zaustave Tanosa. U svemiru, Tor takođe udružuje snage sa Čuvarima galaksije, Star-Lordom, Draksom, Raketom, Grutom, Mantisom, i Gamora, ćerka Tanosa koja upozorava Tora na njegovu moć. Tor putuje da pobedi Tanosa sa Raketom i Grutom, dok drugi Čuvari udružuju snage sa Starkom, Strejndžom i Parkerom. U Vakandi, Stiv Rodžers i njegov tim, Crna udovica, Falkon, Skarletna veštica , Ratna mašina i Brus Bener da zaštite Vision i Kamen uma u njegovo čelo. Uz zaštitu kralja T\'Čale/Crnog pantera i njegove vojske Vakande, Tanos će doći da svako uništi pola univerzuma.', 8.4, 'Akcija Avantura Naucna-Fantastika', 'imgs/AIF.jpg', 'imgs/slike/AIF.jpg', 10),
(5, 'Man of Steel', 2013, 143, 'USA', 'Kal-El, sin Jor-Ela i Lare, poslan je na Zemlju nakon što njegova matična planeta Kripton dovede do potpunog spaljivanja. Sada uzimajući ime „Klark Kent“, on zatim otkriva svoju pravu ličnost kada je vođen da postane Supermen: heroj posvećen zaštiti Zemljine sudbine i štete koja joj preti. Međutim, general Zod, građanin Kriptona i njegov vojskovođa, drugačije gleda na sudbinu Zemlje i odlučuje da je iskoristi uz žrtvu za sve ljude. Supermen, uz pomoć sadašnje vojne i novinske reporterke Lois Lane, sklapa savez kako bi sprečio Zoda da uništi ljudsko postojanje.', 7.1, 'Akcija Avantura Naucna-Fantastika', 'imgs/MoS.jpg', 'imgs/slike/MoS.jpg', 3),
(6, 'Batman v Superman: Dawn of Justice', 2016, 151, 'USA', 'Šira javnost je zabrinuta zbog toga što ima Supermena na svojoj planeti i puštanja \"Mračnog viteza\" - Betmena - da juri ulicama Gotama. Dok se ovo dešava, Betmen koji je fobičan moći pokušava da napadne Supermena. U međuvremenu, Supermen pokušava da se dogovori, a Leks Lutor, kriminalni mozak i milioner, pokušava da iskoristi svoje prednosti u borbi protiv „Čoveka od čelika“.', 6.4, 'Akcija Avantura Naucna-Fantastika', 'imgs/BvS.jpg', 'imgs/slike/BvS.jpg', 5),
(7, 'Fast X', 2023, 141, 'USA', 'Tokom mnogih misija i protiv nemogućih izgleda, Dom Toreto (Vin Dizel) i njegova porodica su nadmudrili, iznervirali i nadmašili svakog neprijatelja na svom putu. Sada se suočavaju sa najsmrtonosnijim protivnikom sa kojim su se ikada suočili: zastrašujućom pretnjom koja se pojavljuje iz senki prošlosti koja je podstaknuta krvnom osvetom i koja je odlučna da razbije ovu porodicu i uništi sve – i sve – koje Dom voli , zauvek.', 6.3, 'Akcija Avantura Krimi', 'imgs/FX.jpg', 'imgs/slike/FX.jpg', 10),
(8, 'John Wick 4', 2023, 169, 'USA', 'Osuđen od strane tiranskog Visokog stola da bude u bekstvu do kraja svog života, smrtonosni maestro ubica Džon Vik (2014) kreće u sizifovsku misiju samoubilačkog besa da odluči o svojoj sudbini nakon nemilosrdnog pokolja u Džon Viku: Poglavlje 3 - Parabelum (2019). Konačno, Džonovo nasilno putovanje, podstaknuto osvetom i tugom, na kraju ga vodi u sudbonosnu konfrontaciju sa svojim bivšim poslodavcima, majstorima zločina koji su ga primorali na izgnanstvo. I dok se krvlju umrljana osveta za uništavanje onih koji vuku konce nastavlja, stari saputnici se suočavaju sa brutalnim posledicama prijateljstva, a svemoćni, dobro povezani protivnici se pojavljuju da donesu Vikovu glavu na tanjir. Ali priča je jeftina - sada oružje ima poslednju reč. Može li Baba Jaga, mračni mesija smrti, učiniti da se svaki metak računa u ovoj krvavoj, jednom zauvek borbi za slobodu?', 8.1, 'Akcija Krimi Triler', 'imgs/JW4.jpg', 'imgs/slike/JW4.jpg', 10),
(9, 'No Time to Die', 2021, 163, 'UK', 'Nakon što je napustio aktivnu službu, Džejms Bond se konačno smirio i uživa u mirnom životu. Ali njegov mir je kratkog veka kada mu se obrati stari prijatelj Feliks Leiter da dobije zadatak da pomogne u oporavku kidnapovanog naučnika. On ne shvata da ga njegova prošlost polako sustiže dok misija postaje opasnija na svakom koraku. Džejms ubrzo saznaje da mora da se suoči sa novim misterioznim neprijateljem koji je odlučan da promeni svet po njegovom liku.', 7.3, 'Akcija Avantura Triler', 'imgs/NTTD.jpg', 'imgs/slike/NTTD.jpg', 5),
(10, 'Django Unchained', 2012, 165, 'USA', 'Uz pomoć nemačkog lovca na glave, oslobođeni rob kreće da spase svoju ženu od brutalnog vlasnika plantaže u Misisipiju. Uz pomoć nemačkog lovca na glave, oslobođeni rob kreće da spase svoju ženu od brutalnog vlasnika plantaže u Misisipiju.', 8.4, 'Drama Vestern', 'imgs/DU.jpg', 'imgs/slike/DU.jpg', 3),
(18, 'Green Book', 2018, 130, 'USA', 'U Bronksu 1962. italijansko-američki izbacivač Toni Lip traži novo zaposlenje dok je Kopakabana zatvorena zbog renoviranja. Pozvan je na intervju sa dr Donom Širlijem, afroameričkim pijanistom kome je potreban vozač za njegovu osmonedeljnu koncertnu turneju po srednjem zapadu i dubokom jugu.', 8.2, 'Biografija Komedija Drama', 'imgs/GB.jpg', 'imgs/slike/GB.jpg', 3),
(21, 'Pirates of the Caribbean: At World\'s End', 2007, 169, 'USA', 'Da bi povećao svoju moć i moć East India Trading Compani na Karibima, lord Katler Beket pogubljuje svakoga, uključujući žene i decu, za koje se sumnja da su ili su iz daljine povezani sa piraterijom. Beket, koji sada poseduje srce Dejvija Džonsa, naređuje Džonsu da uništi sve piratske brodove.', 7.1, 'Akcija Avantura Fantastika', 'imgs/PoC3.jpg', 'imgs/slike/PoC3.jpg', 2),
(22, 'Fury', 2014, 134, 'USA', 'Tokom koordinisane invazije zapadnih saveznika na nacističku Nemačku u proleće 1945, i sa Adolfom Hitlerom koji se spremao za poslednju obranu, tehnički narednik američke armije iz 2. oklopne divizije Don „Vardadi“ Kolijer i njegova odana posada moćnog tenka M4 Sherman bori se zubima i noktima protiv očajnog neprijatelja. Rat je pakao za sve ljude, a kamoli za Kolijerovog neiskusnog novog mitraljezaca, Normana, koji mora brzo da dođe u formu ako želi da ima šansu za borbu duboko iza neprijateljskih linija. Na pobedničkoj topovskoj cevi od 76 mm proždrljive ratne mašine, muškarci su naslikali „Furiju“ smelom belom bojom kako bi proterali užase rata. Hoće li Fjurijeva petočlana posada preživeti da se bori još jedan dan?', 7.4, 'Akcija Drama Ratni', 'imgs/F.png', 'imgs/slike/F.jpg', 3),
(23, 'The last Christmas', 2019, 103, 'UK', 'To je božićna sezona 2017. godine u Londonu. Od kada se oporavila od ozbiljnog zdravstvenog problema koji joj je mogao oduzeti život, tog zdravstvenog problema koji je kulminirao na Božić prošle godine, Kate, čija je porodica emigrirala iz bivše Jugoslavije bežeći od Baltičkih ratova, postala je drugačija osoba, i to ne na bolje. Sada neodgovorna i sebična, ostaje bez prijateljskih kreveta na kojima bi mogla spavati, svi su došli do poslednjeg slama s njom. Ova krevet-hopping situacija joj i dalje deluje poželjno u odnosu na povratak kući svojim roditeljima, posebno ne želeći da se suoči sa svojom neosetljivom i nametljivom majkom. Radeci kao prodavac u prodavnici Yuletide, prodavnici koja je posvećena Božiću i koja ulazi u najprometniji deo godine, ona je stalno blizu poslednjeg slama sa svojim šefom, kineskom ženom koja je uzela ime Santa za posao i koja je Kate zadržala samo zbog sećanja na vreme kada je bila vredna za posao. Kate sada teži ka životu kao izvođač u mjuziklu, radeći pod pogrešnim uverenjem da će je samo hrabrost dovesti do posla. U ovoj situaciji, Kate sreće Toma, koga smatra da joj se udvara, ali ga odbija jer nije njen tip. Međutim, on uporno nastavlja i na kraju joj pokazuje drugu stranu Londona i drugu stranu života. Ali kako Kate počinje osećati nežnosti prema njemu i vidi ga kao važnu emocionalnu podršku, on, čije namere priznaje da nisu romantične, postaje sve teže pronaći, a jedino što zna o njemu je da volontira noću u skloništu za beskućnike. U njihovom zajedničkom iskustvu, pitanje postaje hoće li ikada uskladiti svoje živote, uzimajući u obzir razlog zbog kojeg je Tom uopšte uporan s njom.', 6.5, 'Komedija Drama Fantazija', 'imgs/Christmas.jpg', '', 5),
(24, 'Ghosted', 2023, 116, 'USA', 'U Vašingtonu DC, potrebiti farmer Koul Terner prodaje proizvode sa farme svog oca na pijaci, čežeći za svojom bivšom devojkom. Neočekivano, prelepa trgovkinja umetninama Sejdi Rouds dolazi želeći da kupi cveće, i Koul pomaže svom prijatelju koji trenutno nije prisutan. Dolazi do svađe između Koul-a i Sejdi, a kada se njegov prijatelj vrati, ona mu kaže da je postojala seksualna tenzija u njihovom razgovoru i ubedi Koul-a da porazgovara sa Sejdi. Prati Sejdi, provode dan i noć zajedno i imaju jednu noćnu avanturu. Kada se Koul vrati kući, kaže svojoj porodici da je zaljubljen u nju i da joj je poslao nekoliko poruka, ali da mu nije odgovorila. Njegov GPS pokazuje da je ona u Londonu i njegova porodica ga ubedi da putuje u London da je sretne. Putuje i uskoro saznaje da Sejdi nije trgovkinja umetninama, već tajna agentkinja CIA-e na najteži mogući način.', 5.8, 'Akcija Avantura Komedija', 'imgs/ghosted.png', '', 8),
(25, 'Ocean\'s eleven', 2001, 116, 'USA', 'Oušen izlazi iz zatvora u Nju Džersiju noseći snove o osveti prema Teriju Benediktu (Endi Garsija), čoveku koji mu je ukrao bivšu ženu. Benedikt poseduje tri kazino-hotela u Las Vegasu: Belađio, Miridž i MGM Grand. Sva tri kazina dele jedan sef, a Oušen planira da okupi ekipu kako bi ukrao novac iz sefa.', 7.7, 'Krimi Triler', 'imgs/OE1.jpg', '', 3),
(26, 'Ocean\'s twelve', 2004, 125, 'USA', 'Izveli su jednu od najvećih pljački ikada, a sada imaju još jedan zadatak da završe. Oceanova jedanaestorka, koju čine Dejni Oušen (Kluni), Rusti Rajan (Pit) i Linus Koldvel (Dejmon) i drugi, svi su mislili da će moći da uživaju u svom novcu, ali neko ima druge planove. Teri Benedikt (Garsija) i dalje vrišti zbog gubitka svog novca i želi ga nazad. Ekipa sada ima zadatak da vrati sav potrošeni novac ili će se suočiti sa zatvorom. Kako će ga sve vratiti? Tako što će izvesti još jedan neverovatan plan.', 6.5, 'Krimi Triler', 'imgs/OT2.jpg', '', 3),
(27, 'Ocean\'s thrirteen', 2007, 122, 'USA', 'Poslednji put kada smo videli ekipu Dejnia Oušena, vraćali su nemilosrdnom vlasniku kazina Teriju Benediktu milione koje su mu ukrali. Međutim, prošlo je neko vreme od tada, a uskoro će se sve promeniti. Kada jedan od njih, Ruben Tiškof, gradi hotel sa drugim vlasnikom kazina, Vilijem Benkom, poslednje što je želeo bilo je da bude izbačen iz posla lično od strane odvratnog Bena. Bencov odnos ide toliko daleko da nađe zadovoljstvo u Tiškofovoj nesreći kada ga dvostruko izda, dovodeći Rubena do srčanog udara i hospitalizacije. Međutim, Dejni i njegova ekipa neće dozvoliti da Benk prođe nekažnjeno za ono što je učinio svom prijatelju. Udružujući se sa svojim starim neprijateljem Benediktom, koji sam ima račune da poravna s Benkom, ekipa kreće da sprovede veliki plan; plan koji će se odigrati na dan otvaranja Bencovog najnovijeg hotela. Nisu u tome zbog novca, već zbog osvete.', 6.9, 'Krimi Triler', 'imgs/OT3.jpg', '', 3);

-- --------------------------------------------------------

--
-- Table structure for table `glumac`
--

CREATE TABLE `glumac` (
  `glumac_id` int(11) NOT NULL,
  `ime` varchar(50) NOT NULL,
  `prezime` varchar(50) NOT NULL,
  `datumRodj` date NOT NULL,
  `zemljaporekla` varchar(40) NOT NULL,
  `prikazan` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `glumac`
--

INSERT INTO `glumac` (`glumac_id`, `ime`, `prezime`, `datumRodj`, `zemljaporekla`, `prikazan`) VALUES
(1, 'Henry', 'Cavil', '1983-05-05', 'UK', 0),
(2, 'Ben', 'Affleck', '1972-08-15', 'USA', 1),
(3, 'Russell', 'Crowe', '1964-04-07', 'Novi Zeland', 1),
(4, 'Michael', 'Shannon', '1974-08-07', 'USA', 0),
(5, 'Brad', 'Pitt', '1963-12-18', 'USA', 1),
(6, 'Shia', 'LaBeouf', '1986-06-11', 'USA', 0),
(7, 'Keanu', 'Reeves', '1964-09-02', 'Liban', 0),
(8, 'Jon', 'Bernthal', '1976-09-20', 'USA', 1),
(9, 'Scott', 'Adkins', '1976-06-17', 'UK', 1),
(10, 'Donnie', 'Yen', '1963-07-27', 'Kina', 0),
(11, 'Robert', 'Downey', '1965-04-04', 'USA', 0),
(12, 'Chris', 'Evans', '1981-06-13', 'USA', 0),
(13, 'Tom', 'Holland', '1996-06-01', 'UK', 0),
(14, 'Chris', 'Hemsworth', '1983-08-11', 'Australija', 0),
(15, 'Josh', 'Brolin', '1968-02-12', 'USA', 0),
(16, 'Scarlett', 'Johansson', '1984-11-22', 'USA', 1),
(17, 'Johnny', 'Depp', '1963-06-09', 'USA', 0),
(18, 'Keira', 'Knightley', '1985-03-26', 'UK', 0),
(19, 'Orlando', 'Bloom', '1977-01-13', 'UK', 0),
(20, 'Vin', 'Diesel', '1967-07-18', 'USA', 1),
(21, 'Paul ', 'Walker', '1973-09-12', 'USA', 0),
(22, 'Dwayne', 'Johnson', '1972-05-02', 'USA', 0),
(23, 'Danie', 'Craig', '1968-03-02', 'UK', 0),
(24, 'Ana de', 'Armas', '1988-04-30', 'Kuba', 0),
(25, 'Jamie', 'Foxx', '1967-12-13', 'USA', 0),
(26, 'Viggo', 'Mortensen', '1958-10-20', 'USA', 0),
(27, 'Mahershala', 'Ali', '1974-02-16', 'USA', 1),
(28, 'Boris', 'Isakovic', '1966-12-14', 'Serbia', 0),
(29, 'Emilia', 'Clarke', '1986-10-23', 'UK', 0),
(30, 'George', 'Clooney', '1961-05-06', 'USA', 0),
(31, 'Matt', 'Damon', '1970-10-08', 'USA', 0);

-- --------------------------------------------------------

--
-- Table structure for table `korisnik`
--

CREATE TABLE `korisnik` (
  `id_korisnika` int(11) NOT NULL,
  `ime` varchar(50) NOT NULL,
  `prezime` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `korisnik`
--

INSERT INTO `korisnik` (`id_korisnika`, `ime`, `prezime`, `email`, `password`) VALUES
(1, 'Pera', 'Peric', 'pera@gmail.com', 'd8795f0d07280328f80e59b1e8414c49'),
(2, 'Mika', 'Mikic', 'mika@gmail.com', '07af613eea059030daaed3bde1fd1ce7'),
(3, 'admin', 'admin', 'admin@gmail.com', '21232f297a57a5a743894a0e4a801fc3');

-- --------------------------------------------------------

--
-- Table structure for table `korpa`
--

CREATE TABLE `korpa` (
  `korpa_id` int(11) NOT NULL,
  `cena` int(11) DEFAULT NULL,
  `film_id` int(11) DEFAULT NULL,
  `korisnik_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `korpa`
--

INSERT INTO `korpa` (`korpa_id`, `cena`, `film_id`, `korisnik_id`) VALUES
(29, 22, 4, 2),
(76, 3, 27, 1),
(77, 5, 6, 1);

-- --------------------------------------------------------

--
-- Table structure for table `reditelj`
--

CREATE TABLE `reditelj` (
  `reditelj_id` int(11) NOT NULL,
  `ime` varchar(50) NOT NULL,
  `prezime` varchar(50) NOT NULL,
  `datumRodj` date NOT NULL,
  `zemljaporekla` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `reditelj`
--

INSERT INTO `reditelj` (`reditelj_id`, `ime`, `prezime`, `datumRodj`, `zemljaporekla`) VALUES
(2, 'Zack', 'Snyder', '1966-03-01', 'USA'),
(3, 'Cary', 'Fukunaga', '1977-07-10', 'USA'),
(4, 'Peter', 'Jackson', '1961-10-31', 'Novi Zeland'),
(5, 'Anthony', 'Russo', '1970-02-03', 'USA'),
(6, 'Joe', 'Russo', '1970-07-18', 'USA'),
(7, 'Chad', 'Stahelski', '1968-09-20', 'USA'),
(8, 'Louis', 'Leterrier', '1973-06-17', 'Francuska'),
(9, 'David', 'Ayer', '1968-01-18', 'USA'),
(10, 'Gore', 'Verbinski', '1964-03-16', 'USA'),
(11, 'Quentin', 'Tarantino', '1963-03-27', 'USA'),
(12, 'Peter', 'Farrelly', '1956-12-17', 'USA'),
(13, 'Paul', 'Feig', '1962-09-17', 'USA'),
(14, 'Steven', 'Soderbergh', '1963-01-14', 'USA'),
(15, 'Dexter', 'Fletcher', '0000-00-00', 'UK');

-- --------------------------------------------------------

--
-- Table structure for table `reditelj_film`
--

CREATE TABLE `reditelj_film` (
  `reditelj_film_id` int(11) NOT NULL,
  `reditelj_id` int(11) DEFAULT NULL,
  `film_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `reditelj_film`
--

INSERT INTO `reditelj_film` (`reditelj_film_id`, `reditelj_id`, `film_id`) VALUES
(1, 2, 5),
(2, 2, 6),
(3, 2, 2),
(4, 4, 10),
(5, 6, 3),
(6, 6, 4),
(7, 5, 3),
(8, 5, 4),
(9, 8, 7),
(10, 7, 8),
(11, 10, 21),
(12, 3, 9),
(13, 12, 18),
(15, 13, 23),
(16, 9, 22),
(17, 14, 25),
(18, 14, 26),
(19, 14, 27),
(20, 15, 24);

-- --------------------------------------------------------

--
-- Table structure for table `uloga`
--

CREATE TABLE `uloga` (
  `uloga_id` int(11) NOT NULL,
  `glumac_id` int(11) DEFAULT NULL,
  `film_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `uloga`
--

INSERT INTO `uloga` (`uloga_id`, `glumac_id`, `film_id`) VALUES
(1, 1, 6),
(2, 2, 6),
(3, 1, 2),
(4, 2, 2),
(5, 1, 5),
(6, 3, 5),
(7, 15, 3),
(8, 15, 4),
(9, 7, 8),
(10, 9, 8),
(11, 13, 3),
(12, 13, 4),
(13, 12, 3),
(14, 12, 4),
(15, 14, 3),
(16, 14, 4),
(17, 16, 3),
(18, 16, 4),
(19, 10, 8),
(21, 17, 21),
(22, 19, 21),
(23, 25, 10),
(24, 24, 9),
(25, 20, 7),
(26, 21, 7),
(27, 22, 7),
(30, 4, 5),
(31, 23, 9),
(32, 27, 18),
(33, 26, 18),
(34, 5, 22),
(35, 6, 22),
(36, 8, 22),
(37, 29, 23),
(38, 28, 23),
(39, 24, 24),
(40, 12, 24),
(41, 30, 25),
(42, 30, 27),
(43, 30, 26),
(44, 5, 25),
(45, 5, 27),
(46, 5, 26),
(47, 31, 25),
(48, 31, 27),
(49, 31, 26),
(50, 11, 3),
(51, 11, 4),
(53, 18, 21);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `film`
--
ALTER TABLE `film`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `glumac`
--
ALTER TABLE `glumac`
  ADD PRIMARY KEY (`glumac_id`);

--
-- Indexes for table `korisnik`
--
ALTER TABLE `korisnik`
  ADD PRIMARY KEY (`id_korisnika`);

--
-- Indexes for table `korpa`
--
ALTER TABLE `korpa`
  ADD PRIMARY KEY (`korpa_id`),
  ADD UNIQUE KEY `unique_combination` (`film_id`,`korisnik_id`),
  ADD KEY `korisnik_id` (`korisnik_id`);

--
-- Indexes for table `reditelj`
--
ALTER TABLE `reditelj`
  ADD PRIMARY KEY (`reditelj_id`);

--
-- Indexes for table `reditelj_film`
--
ALTER TABLE `reditelj_film`
  ADD PRIMARY KEY (`reditelj_film_id`),
  ADD KEY `reditelj_film_ibfk_1` (`reditelj_id`),
  ADD KEY `reditelj_film_ibfk_2` (`film_id`);

--
-- Indexes for table `uloga`
--
ALTER TABLE `uloga`
  ADD PRIMARY KEY (`uloga_id`),
  ADD KEY `uloga_ibfk_1` (`glumac_id`),
  ADD KEY `uloga_ibfk_2` (`film_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `film`
--
ALTER TABLE `film`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `glumac`
--
ALTER TABLE `glumac`
  MODIFY `glumac_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `korisnik`
--
ALTER TABLE `korisnik`
  MODIFY `id_korisnika` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `korpa`
--
ALTER TABLE `korpa`
  MODIFY `korpa_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;

--
-- AUTO_INCREMENT for table `reditelj`
--
ALTER TABLE `reditelj`
  MODIFY `reditelj_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `reditelj_film`
--
ALTER TABLE `reditelj_film`
  MODIFY `reditelj_film_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `uloga`
--
ALTER TABLE `uloga`
  MODIFY `uloga_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `korpa`
--
ALTER TABLE `korpa`
  ADD CONSTRAINT `korpa_ibfk_1` FOREIGN KEY (`film_id`) REFERENCES `film` (`id`),
  ADD CONSTRAINT `korpa_ibfk_2` FOREIGN KEY (`korisnik_id`) REFERENCES `korisnik` (`id_korisnika`);

--
-- Constraints for table `reditelj_film`
--
ALTER TABLE `reditelj_film`
  ADD CONSTRAINT `reditelj_film_ibfk_1` FOREIGN KEY (`reditelj_id`) REFERENCES `reditelj` (`reditelj_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reditelj_film_ibfk_2` FOREIGN KEY (`film_id`) REFERENCES `film` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `uloga`
--
ALTER TABLE `uloga`
  ADD CONSTRAINT `uloga_ibfk_1` FOREIGN KEY (`glumac_id`) REFERENCES `glumac` (`glumac_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `uloga_ibfk_2` FOREIGN KEY (`film_id`) REFERENCES `film` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
