/***************************** dogs ****************************/

ALTER TABLE [dbo].[dogs]  WITH CHECK ADD  CONSTRAINT [FK_dogs_ownerid] FOREIGN KEY([ownerid])
REFERENCES [dbo].[owner] ([id])
GO

ALTER TABLE [dbo].[dogs] CHECK CONSTRAINT [FK_dogs_ownerid]
GO

/***************************** cats ****************************/

ALTER TABLE [dbo].[cats]  WITH CHECK ADD  CONSTRAINT [FK_cats_ownerid] FOREIGN KEY([ownerid])
REFERENCES [dbo].[owner] ([id])
GO

ALTER TABLE [dbo].[cats] CHECK CONSTRAINT [FK_cats_ownerid]
GO