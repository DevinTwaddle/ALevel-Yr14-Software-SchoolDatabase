UPDATE Scheduled_Lessons SET Scheduled_Lessons.[End_Date] = 
IIf([Scheduled_Lessons].[Number_Of_Weeks]='5 Weeks', DateADD (Day, 35, [Scheduled_Lessons].[Start_Date]),
IIf([Scheduled_Lessons].[Number_of_weeks]='10 Weeks',DateADD (Day, 70, [Scheduled_Lessons].[Start_Date]),
IIf([Scheduled_Lessons].[Number_Of_Weeks]='15 Weeks',DateADD (Day, 105, [Scheduled_Lessons].[Start_Date]),
IIf([Scheduled_Lessons].[Number_of_weeks]='20 Weeks',DateADD (Day, 140, [Scheduled_Lessons].[Start_Date]),
IIf([Scheduled_Lessons].[Number_of_weeks]='30 Weeks',DateADD (Day, 210, [Scheduled_Lessons].[Start_Date],
