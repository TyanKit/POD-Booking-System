/*<!-- main.js -->*/
// Form Validation
document.addEventListener('DOMContentLoaded', function() {
    const bookingForm = document.querySelector('.booking-form');
    const contactForm = document.querySelector('.contact-form');

    if (bookingForm) {
        bookingForm.addEventListener('submit', function(e) {
            e.preventDefault();
            // Add your form validation and submission logic here
            alert('Đặt chỗ thành công! Chúng tôi sẽ liên hệ với bạn sớm.');
        });
    }

    if (contactForm) {
        contactForm.addEventListener('submit', function(e) {
            e.preventDefault();
            // Add your form validation and submission logic here
            alert('Cảm ơn bạn đã liên hệ! Chúng tôi sẽ phản hồi sớm nhất có thể.');
        });
    }
});

// Mobile Menu Toggle
const menuButton = document.createElement('button');
menuButton.classList.add('menu-toggle');
menuButton.innerHTML = '☰';
document.querySelector('.nav').prepend(menuButton);

menuButton.addEventListener('click', function() {
    document.querySelector('.nav-links').classList.toggle('show');
});
