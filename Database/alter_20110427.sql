/*
 * Run this script only if items table doesnot have
 * ExpiryInDays and CompanyID field.
 * please check before running this script
 */
ALTER TABLE items ADD 
	ExpiryInDays INT DEFAULT 0,
	CompanyID INT NULL,
	CONSTRAINT FK_Items_Companies 
		FOREIGN KEY(CompanyID)
		REFERENCES Companies(ID)
GO
