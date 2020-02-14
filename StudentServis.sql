CREATE TABLE "fakultet" (
  "ID_fakultet" int4 NOT NULL,
  "naziv" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "adresa" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  CONSTRAINT "fakultet_pkey" PRIMARY KEY ("ID_fakultet")
);
ALTER TABLE "fakultet" OWNER TO "postgres";

CREATE TABLE "partner" (
  "ID_partner" int4 NOT NULL,
  "naziv" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "adresa" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "oib" int4 NOT NULL,
  "iban" int4 NOT NULL,
  CONSTRAINT "partner_pkey" PRIMARY KEY ("ID_partner")
);
ALTER TABLE "partner" OWNER TO "postgres";

CREATE TABLE "racun" (
  "ID_racun" int4 NOT NULL,
  "datum_izrade" timestamp(6) NOT NULL,
  "opis_posla" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "satnica" int4 NOT NULL,
  "datum_pocetka" timestamp(6) NOT NULL,
  "datum_zavrsetka" timestamp(6) NOT NULL,
  "vk_zaposlenik" int4 NOT NULL,
  "vk_student" int4 NOT NULL,
  "vk_partner" int4 NOT NULL,
  CONSTRAINT "racun_pkey" PRIMARY KEY ("ID_racun")
);
ALTER TABLE "racun" OWNER TO "postgres";

CREATE TABLE "student" (
  "ID_student" int4 NOT NULL,
  "ime" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "prezime" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "jmbag" int4 NOT NULL,
  "iban" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "vk_fakultet" int4 NOT NULL,
  CONSTRAINT "student_pkey" PRIMARY KEY ("ID_student")
);
ALTER TABLE "student" OWNER TO "postgres";

CREATE TABLE "zaposlenik" (
  "ID_zaposlenik" int4 NOT NULL,
  "ime" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "prezime" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "oib" int4 NOT NULL,
  "korime" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "lozinka" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  CONSTRAINT "zaposlenik_pkey" PRIMARY KEY ("ID_zaposlenik")
);
ALTER TABLE "zaposlenik" OWNER TO "postgres";

ALTER TABLE "racun" ADD CONSTRAINT "vk_partner" FOREIGN KEY ("vk_partner") REFERENCES "partner" ("ID_partner") ON DELETE CASCADE ON UPDATE RESTRICT;
ALTER TABLE "racun" ADD CONSTRAINT "vk_student" FOREIGN KEY ("vk_student") REFERENCES "student" ("ID_student") ON DELETE CASCADE ON UPDATE RESTRICT;
ALTER TABLE "racun" ADD CONSTRAINT "vk_zaposlenik" FOREIGN KEY ("vk_zaposlenik") REFERENCES "zaposlenik" ("ID_zaposlenik") ON DELETE CASCADE ON UPDATE RESTRICT;
ALTER TABLE "student" ADD CONSTRAINT "vk_fakultet" FOREIGN KEY ("vk_fakultet") REFERENCES "fakultet" ("ID_fakultet") ON DELETE CASCADE ON UPDATE RESTRICT;

