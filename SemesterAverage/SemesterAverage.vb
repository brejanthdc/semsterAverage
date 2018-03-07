'Lab 2: Semester Average 
'By: Brejanth Rajendran
'Date:2/20/2018
'Description: User will enter in grades and the program will give a grade value for each grade and calculate their average

Public Class frmSemesterAverage
    Const totalCourses As Integer = 6 'Constant variable for the total amount of courses the student has
    Dim userInputString As String = String.Empty 'This variable is used to store the user inputs 
    Dim userInputValidated As Double = 0.0 ' This is the variable that the user's validated input goes
    Dim finalGrade(totalCourses - 1) As Double 'Array that is used to store the user's validated inputs
    Dim errrorMessage As String ' Used to store error messages
    Dim GradeAverage As Double = 0.0 ' This variable is to calculate the grade value

    Private Sub frmSemesterAverage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ''Valdation function
    Private Function Validate(ByVal UserInput As String, ByRef userInputValidated As Double) As Boolean ' This function will get the user input, and return a true/false value and the number the user entered
        Dim userInputDouble As Double = 0.0  'This variable is used to store the user inputs after it is validiated
        Dim returnValue As Boolean = True 'Returns a true or false value which tells the code if the number has passed the validation

        If (Double.TryParse(UserInput, userInputDouble)) Then 'Trys to parse the user input as a double 

            If userInputDouble >= 0 AndAlso userInputDouble <= 100 Then ' if the number is a double it then checks if its within the range
                userInputValidated = userInputDouble ' The user input has been validated so it stores the number back into the userInputValidated to send back to the main code
                returnValue = True 'Returns a true value which the code will use to progress
            Else
                returnValue = False ' Returns a false value which the program will use for an error message

            End If
        Else
            returnValue = False ' Returns a false value which the program will use for an error message

        End If
        Return returnValue ' Returns the return value

    End Function

    '' Grade letter function
    Private Function Grade(userInputValidated As Double) As String ' Takes the validiated number and assigns a grade value and returns that grade value.

        Dim letterGrade As String ' Variable that is used to store the grade letter which will returned to the main program.

        If userInputValidated >= 90 Then ' Grade value for A+
            letterGrade = "A+"
        ElseIf userInputValidated >= 85 Then ' Grade value for A
            letterGrade = "A"
        ElseIf userInputValidated >= 80 Then ' Grade value for A-
            letterGrade = "A-"
        ElseIf userInputValidated >= 77 Then ' Grade value for B+
            letterGrade = "B+"
        ElseIf userInputValidated >= 73 Then ' Grade value for B
            letterGrade = "B"
        ElseIf userInputValidated >= 70 Then ' Grade value for B-
            letterGrade = "B-"
        ElseIf userInputValidated >= 67 Then ' Grade value for C+
            letterGrade = "C+"
        ElseIf userInputValidated >= 63 Then  ' Grade value for C
            letterGrade = "C"
        ElseIf userInputValidated >= 60 Then ' Grade value for C-
            letterGrade = "C-"
        ElseIf userInputValidated >= 57 Then ' Grade value for D+
            letterGrade = "D+"
        ElseIf userInputValidated >= 53 Then ' Grade value for D
            letterGrade = "D"
        ElseIf userInputValidated >= 50 Then ' Grade value for D-
            letterGrade = "D-"
        ElseIf userInputValidated <= 49 Then ' Grade value for F
            letterGrade = "F"

        End If


        Return letterGrade 'Returns the grade letter value back to the program

    End Function

    Private Sub lblErrorList_Click(sender As Object, e As EventArgs) Handles lblErrorList.Click

    End Sub

    Private Sub txtCourse1UserEntry_LostFocus(sender As Object, e As EventArgs) Handles txtCourse1UserEntry.LostFocus
        userInputString = txtCourse1UserEntry.Text ' Sets the user input to userInputString variable

        lblErrorList.Text = "" ' Resets the error message box to clear previous errors
        lblCourse1Grade.Text = "" ' Resets the grade so that user can re-enter a different grade

        If Validate(userInputString, userInputValidated) = True Then ' Checks if the validate function has passed
            lblCourse1Grade.Text = Grade(userInputValidated) ' Uses the grade function to output to the windows form
            finalGrade(0) = userInputValidated ' Stores the user's validated grade into the first slot of the array
        Else
            lblErrorList.Text = "Please ensure the number you input is between 0 and 100" 'Error message if the user input is not valid
        End If


    End Sub

    Private Sub txtCourse2UserEntry_LostFocus(sender As Object, e As EventArgs) Handles txtCourse2UserEntry.LostFocus
        userInputString = txtCourse2UserEntry.Text ' Sets the user input to userInputString variable

        lblErrorList.Text = "" ' Resets the error message box to clear previous errors
        lblCourse2Grade.Text = "" ' Resets the grade so that user can re-enter a different grade

        If Validate(userInputString, userInputValidated) = True Then ' Checks if the validate function has passed
            lblCourse2Grade.Text = Grade(userInputValidated) 'Uses the grade function to output to the windows form
            finalGrade(1) = userInputValidated ' Stores the user's validated grade into the second slot of the array

        Else
            lblErrorList.Text = "Please ensure the number you input is between 0 and 100" 'Error message if the user input is not valid
        End If

    End Sub

    Private Sub txtCourse3UserEntry_LostFocus(sender As Object, e As EventArgs) Handles txtCourse3UserEntry.LostFocus
        userInputString = txtCourse3UserEntry.Text ' Sets the user input to userInputString variable
        lblErrorList.Text = "" ' Resets the error message box to clear previous errors
        lblCourse3Grade.Text = "" 'Resets the grade so that user can re-enter a different grade

        If Validate(userInputString, userInputValidated) = True Then ' Checks if the validate function has passed
            lblCourse3Grade.Text = Grade(userInputValidated) 'Uses the grade function to output to the windows form
            finalGrade(2) = userInputValidated ' Stores the user's validated grade into the third slot of the array

        Else
            lblErrorList.Text = "Please ensure the number you input is between 0 and 100" 'Error message if the user input is not valid
        End If

    End Sub
    Private Sub txtCourse4UserEntry_LostFocus(sender As Object, e As EventArgs) Handles txtCourse4UserEntry.LostFocus
        userInputString = txtCourse4UserEntry.Text ' Sets the user input to userInputString variable
        lblErrorList.Text = "" ' Resets the error message box to clear previous errors
        lblCourse4Grade.Text = "" 'Resets the grade so that user can re-enter a different grade

        If Validate(userInputString, userInputValidated) = True Then ' Checks if the validate function has passed
            lblCourse4Grade.Text = Grade(userInputValidated) 'Uses the grade function to output to the windows form
            finalGrade(3) = userInputValidated ' Stores the user's validated grade into the forth slot of the array

        Else
            lblErrorList.Text = "Please ensure the number you input is between 0 and 100" 'Error message if the user input is not valid


        End If

    End Sub

    Private Sub txtCourse5UserEntry_LostFocus(sender As Object, e As EventArgs) Handles txtCourse5UserEntry.LostFocus
        userInputString = txtCourse5UserEntry.Text ' Sets the user input to userInputString variable
        lblErrorList.Text = "" ' Resets the error message box to clear previous errors
        lblCourse5Grade.Text = "" 'Resets the grade so that user can re-enter a different grade

        If Validate(userInputString, userInputValidated) = True Then ' Checks if the validate function has passed
            lblCourse5Grade.Text = Grade(userInputValidated) 'Uses the grade function to output to the windows form
            finalGrade(4) = userInputValidated ' Stores the user's validated grade into the fifth slot of the array

        Else
            lblErrorList.Text = "Please ensure the number you input is between 0 and 100" 'Error message if the user input is not valid

        End If

    End Sub

    Private Sub txtCourse6UserEntry_LostFocus(sender As Object, e As EventArgs) Handles txtCourse6UserEntry.LostFocus
        userInputString = txtCourse6UserEntry.Text ' Sets the user input to userInputString variable
        lblErrorList.Text = "" ' Resets the error message box to clear previous errors
        lblCourse6Grade.Text = "" ' Resets the grade so that user can re-enter a different grade

        If Validate(userInputString, userInputValidated) = True Then ' Checks if the validate function has passed
            lblCourse6Grade.Text = Grade(userInputValidated) 'Uses the grade function to output to the windows form
            finalGrade(5) = userInputValidated ' Stores the user's validated grade into the sixth slot of the array

        Else
            lblErrorList.Text = "Please ensure the number you input is between 0 and 100" 'Error message if the user input is not valid

        End If

    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblErrorList.Text = "" ' Resets the error message box to clear previous errors
        errrorMessage = "" ' Resets the error message to clear previous errors
        Dim emptyBoxChecker As Double = 0.0 'This is used to check if the text box has nothing in it, it will be a 0 if there is nothing in it


        For counter As Integer = 0 To (totalCourses - 1) ' For loop used to check each entry of the array to see if there are any empty spaces
            emptyBoxChecker = finalGrade(counter) ' Sets the current array slot to the emptyBoxChecker 

            If emptyBoxChecker = 0 Then ' if emptyBoxChecker is 0 (if is no value)
                errrorMessage += "Please ensure the number you input " + "course: " + (counter + 1).ToString + " is between 0 and 100" + vbCrLf ' Creates an error message telling the user where the empty spot is and skips a line
            End If
        Next
        If emptyBoxChecker > 0 Then ' If all the values of the array exist
            btnCalculate.Enabled = False ' Disables the enter button

            txtCourse1UserEntry.Enabled = False ' Disables the first textbox
            txtCourse2UserEntry.Enabled = False ' Disables the second textbox
            txtCourse3UserEntry.Enabled = False ' Disables the third textbox
            txtCourse4UserEntry.Enabled = False ' Disables the fourth textbox
            txtCourse5UserEntry.Enabled = False ' Disables the fifth textbox
            txtCourse6UserEntry.Enabled = False ' Disables the sixth textbox


            For avgCounter As Integer = 0 To (totalCourses - 1) 'Creates a for loop that counts for each day of the week
                GradeAverage = GradeAverage + finalGrade(avgCounter) 'Adds all the numbers the user inputed into the array
            Next

            GradeAverage = GradeAverage / totalCourses  ' Calculates the average of the 6 courses that were entered
            lblSemsterAverage.Text = Math.Round(GradeAverage, 2).ToString 'Outputs the average grade with 2 decimal places to the semster average lbl
            lblFinalGrade.Text = Grade(GradeAverage) ' Uses the grade function to output the grade to the final average grade label
        Else
            lblErrorList.Text = "ERROR(s): " + vbCrLf + errrorMessage ' Displays the error messages for all the courses that were empty

        End If





    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnCalculate.Enabled = True ' Re-enables the calculate button
        txtCourse1UserEntry.Enabled = True 'Re-enables the first course text box
        txtCourse2UserEntry.Enabled = True 'Re-enables the second course text box
        txtCourse3UserEntry.Enabled = True 'Re-enables the third course text box
        txtCourse4UserEntry.Enabled = True 'Re-enables the forth course text box
        txtCourse5UserEntry.Enabled = True 'Re-enables the fifth course text box
        txtCourse6UserEntry.Enabled = True 'Re-enables the sixth course text box

        ReDim finalGrade(totalCourses - 1) 'Resets the contents of the array

        txtCourse1UserEntry.Text = "" 'clears the grade so that user can re-enter a different grade
        txtCourse2UserEntry.Text = "" 'clears the grade so that user can re-enter a different grade
        txtCourse3UserEntry.Text = "" 'clears the grade so that user can re-enter a different grade
        txtCourse4UserEntry.Text = "" 'clears the grade so that user can re-enter a different grade
        txtCourse5UserEntry.Text = "" 'clears the grade so that user can re-enter a different grade
        txtCourse6UserEntry.Text = "" 'clears the grade so that user can re-enter a different grade

        lblCourse1Grade.Text = "" 'Clears the grade letter so that user can re-enter a different grade
        lblCourse2Grade.Text = "" 'Clears the grade letter so that user can re-enter a different grade
        lblCourse3Grade.Text = "" 'Clears the grade letter so that user can re-enter a different grade
        lblCourse4Grade.Text = "" 'Clears the grade letter so that user can re-enter a different grade
        lblCourse5Grade.Text = "" 'Clears the grade letter so that user can re-enter a different grade
        lblCourse6Grade.Text = "" 'Clears the grade letter so that user can re-enter a different grade

        errrorMessage = "" ' Resets the error message for the calculate button to clear previous errors
        lblErrorList.Text = "" ' Resets the error message to clear previous errors

        txtCourse1UserEntry.Focus() 'Sets the focus back to the first text box

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'Exits the program
    End Sub



End Class
