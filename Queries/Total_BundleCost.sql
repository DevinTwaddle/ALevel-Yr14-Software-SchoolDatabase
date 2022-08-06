SELECT Students.[StudentID], Students.[First_Name], Students.Surname, Sum(([LessonBundles].[Bundle Cost]*[Grade].[Grade Fee])*[LessonBundles].[Multiplier (Discount Rate)]) AS [Total Cost]
FROM [LessonBundles] INNER JOIN (Grade INNER JOIN (Students INNER JOIN [LessonsPurchased] ON Students.[StudentID] = [LessonsPurchased].[StudentID]) ON Grade.[GradeID] = Students.[GradeID]) ON [LessonBundles].[LessonBundleID] = [LessonsPurchased].[LessonBundleID]
GROUP BY Students.[StudentID], Students.[First_Name], Students.Surname;
