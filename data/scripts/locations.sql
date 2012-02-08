PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
    CREATE TABLE locations (
        location_id text collate nocase NOT NULL PRIMARY KEY,
        max_storage integer NOT NULL
    );
INSERT INTO "locations" VALUES('Binder A', 500);
INSERT INTO "locations" VALUES('Binder B', 500);
COMMIT;
