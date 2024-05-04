 $(document).ready(function() {
        $('#btnSubmit').click(function (event) {
            // Prevent form submission
            event.preventDefault();

            // Perform form validation
            var name = $('#name').val();
            var email = $('#email').val();
            var password = $('#password').val();
            var age = $('#age').val();
            var gender = $('#gender').val();
            var city = $('#city').val();
            var country = $('#country').val();
            var pincode = $('#pincode').val();

            var emailRegex = /^[^\s@]+@gmail\.com$/;
            var passwordRegex = /^(?=.*\d).{8,}$/;

            if (name === "") {
                alert("Please Enter Name");
            } else if (!emailRegex.test(email)) {
                alert("Please enter a valid email address.");
            } else if (!passwordRegex.test(password)) {
                alert("Password must be at least 8 characters long and contain at least one number.");
            } else if (age === "") {
                alert("Please Enter Age");
            } else if (city === "") {
                alert("Please Enter City");
            } else if (country === "") {
                alert("Please Enter Country");
            } else if (pincode === "") {
                alert("Please Enter Pincode");
            } else {
                // If all validations pass, submit the form
                alert(' Thanks For Register...! We Will Get Back To you');
                // Uncomment the line below to submit the form
                // $(this).unbind('submit').submit();
            }
        });
    });


