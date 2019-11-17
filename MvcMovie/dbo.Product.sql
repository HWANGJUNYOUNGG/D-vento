CREATE TABLE [dbo].[Product] (
    [p_code]          NVARCHAR (450) NOT NULL,
    [p_name]          NVARCHAR (MAX) NOT NULL,
    [p_measure]       INT            NOT NULL,
    [p_amount]        NVARCHAR (MAX) NULL,
    [p_brandname]     NVARCHAR (MAX) NOT NULL,
    [p_customerprice] INT            NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([p_code] ASC)
);

