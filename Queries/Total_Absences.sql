SELECT Students.[StudentID], Students.[First_Name], Students.Surname, Count(Scheduled_Lessons.[StudentID]) AS [Total Absences]
FROM Students INNER JOIN Scheduled_Lessons ON Students.[StudentID] = Scheduled_Lessons.[StudentID]
GROUP BY Students.[StudentID], Students.[First_Name], Students.Surname, Scheduled_Lessons.Attended
HAVING (((Scheduled_Lessons.Attended)=0));
