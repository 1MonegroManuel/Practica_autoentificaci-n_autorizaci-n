<script>
    $(document).ready(function () {
        $('#createUserForm').on('submit', function (event) {
            let valid = true;
            $('#validationSummary').empty();

            // Validate First Name
            if ($('#firstName').val().trim() === '') {
                valid = false;
                $('#firstNameError').text('First Name is required.');
            } else {
                $('#firstNameError').text('');
            }

            // Validate Last Name
            if ($('#lastName').val().trim() === '') {
                valid = false;
                $('#lastNameError').text('Last Name is required.');
            } else {
                $('#lastNameError').text('');
            }

            // Validate Identity Card
            if ($('#identityCard').val().trim() === '') {
                valid = false;
                $('#identityCardError').text('Identity Card is required.');
            } else {
                $('#identityCardError').text('');
            }

            // Prevent form submission if not valid
            if (!valid) {
                event.preventDefault();
                $('#validationSummary').text('Please correct the errors above.');
            }
        });
        });
</script>