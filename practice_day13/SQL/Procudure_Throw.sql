Create proc PrcDivision
	@a Int,
	@b Int
AS
Begin
	Begin Try
		set @a =5;
		set @b = @a/0
		print @b
	End Try
	Begin Catch
		print 'Error is'
		print Error_Message()
	End Catch
End 
Go

Exec PrcDivision 12,0
Go

Create proc prcEvenChek
				@n INT
AS
BEGIN
	Declare 
		@res INT
	BEGIN TRY
		SET @Res = @n%2 
		if (@res = 0) 
		BEGIN
			PRINT 'NO ERROR'
			PRINT 'Even Number'
		END
		ELSE
		BEGIN;
			print 'Error Occurred'
			Throw [ 70000, Error occured, 5]
		END
	END TRY
	BEGIN CATCH
		Print Error_Message()
	END CATCH
END