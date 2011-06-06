-- -----------------------------------------------------------------------
-- Database    : UltFamilyBalance
-- Type        : insert
-- Table       : EntryGroup
-- RecordCount : 7
-- Date        : 26-05-2011 17.37.05
-- -----------------------------------------------------------------------

SET IDENTITY_INSERT EntryGroup ON

INSERT INTO EntryGroup(EntryGroupId, EntryGroupName, EntryGroupDesc) VALUES (1, 'Spese Necessarie', 'Spese mensili necessarie che non possono essere escluse')
INSERT INTO EntryGroup(EntryGroupId, EntryGroupName, EntryGroupDesc) VALUES (2, 'Auto', 'Costo mantenimento auto')
INSERT INTO EntryGroup(EntryGroupId, EntryGroupName, EntryGroupDesc) VALUES (3, 'Marghe', 'Costi mantenimento Margherita')
INSERT INTO EntryGroup(EntryGroupId, EntryGroupName, EntryGroupDesc) VALUES (4, 'Straordinare', 'Costi straordinari non preventivabili che possono essere esclusi dai costi fissi')
INSERT INTO EntryGroup(EntryGroupId, EntryGroupName, EntryGroupDesc) VALUES (5, 'Extra', 'Costi per extra e divertimenti completamente superflui')
INSERT INTO EntryGroup(EntryGroupId, EntryGroupName, EntryGroupDesc) VALUES (6, 'Entrate', 'Entrate')
INSERT INTO EntryGroup(EntryGroupId, EntryGroupName, EntryGroupDesc) VALUES (7, 'Casa', 'Spese per la casa')

SET IDENTITY_INSERT EntryGroup OFF
