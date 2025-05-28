Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class Camera
    Private videoSource As VideoCaptureDevice
    Private videoDevices As FilterInfoCollection

    Private Sub Camera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Find all available video input devices (webcams)
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If videoDevices.Count > 0 Then
            ' Select the first available camera
            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler videoSource.NewFrame, AddressOf VideoSource_NewFrame
            videoSource.Start()
        Else
            MessageBox.Show("No camera found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        ' Display each frame in the PictureBox
        Dim bitmap As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)
        ptbCamera.Image = bitmap
    End Sub

    Private Sub btnCaptured_Click(sender As Object, e As EventArgs) Handles btnCaptured.Click
        ' Capture the current frame displayed in the PictureBox
        If ptbCamera.Image IsNot Nothing Then
            ' Transfer the captured image to AddStudent form
            TransferImageToAddStudent(ptbCamera.Image)
            ' Optionally close the Camera form after capturing
            Me.Close()
        Else
            MessageBox.Show("No image to capture. Ensure the camera is working.", "Capture Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Transfer captured image to AddStudent form
    Private Sub TransferImageToAddStudent(image As Image)
        If image IsNot Nothing Then
            ' Check if AddStudent form is already open
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is AddStudent Then
                    ' Set the captured image to the ptbStudent in the already open AddStudent form
                    CType(frm, AddStudent).ptbStudent.Image = image
                    ' Optionally, if you need to ensure the format is "raw", you could save the image in a specific format
                    ' For example, saving as PNG will preserve quality and retain original format as close to raw as possible:
                    ' Dim rawImage As Bitmap = New Bitmap(image)
                    ' rawImage.Save("path_to_save_image.png", Imaging.ImageFormat.Png)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Camera_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Stop the camera when closing the form
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
        End If
    End Sub
End Class
