PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
    CREATE TABLE discs (
        disc_id text collate nocase NOT NULL PRIMARY KEY,
        page_number text,
        location_id text REFERENCES locations(location_id)
    );
INSERT INTO "discs" VALUES('a001', '01', 'Binder A');
INSERT INTO "discs" VALUES('a002', '01', 'Binder A');
INSERT INTO "discs" VALUES('a003', '05', 'Binder A');
COMMIT;
