SELECT a.StudentID, a.First_Name, a.Surname, b.GradeLevel
FROM Students a, Grade b
WHERE b.GradeID = a.GradeID