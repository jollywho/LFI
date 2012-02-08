PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
    CREATE TABLE disc_titles (
        disc_id text NOT NULL REFERENCES disc_id(discs),
        title_id text collate nocase NOT NULL REFERENCES title_id(titles),
        range text,
        PRIMARY KEY (disc_id, title_id, range)
    );
INSERT INTO "disc_titles" VALUES('a001', 'Air TV', 'Full');
INSERT INTO "disc_titles" VALUES('a002', 'Area 88', '1-12');
INSERT INTO "disc_titles" VALUES('a003', 'Bakuman', '13-26');
INSERT INTO "disc_titles" VALUES('a003', 'Bakuman', '27');
INSERT INTO "disc_titles" VALUES('a003', 'Bakuman OVA', 'Full');
INSERT INTO "disc_titles" VALUES('a002', 'Bakuman', '1-12');
COMMIT;