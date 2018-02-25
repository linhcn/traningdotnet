var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinue').off('click').on('click', function () {
            window.location.href = "/"
        });
        $('#btnUpdate').off('click').on('click', function () {
            var listBook = $('.txtQuantity');
            var cartList = [];
            $.each(listBook, function(i, item) {
                cartList.push({
                    Quantity: $(item).val(),
                    Book: {
                        BookID: $(item).data('id')
                    }
                });
            });

            $.ajax({
                url: '/Cart/Update',
                data: { cartModel: JSON.stringify(cartList) },
                dateType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/Cart/index";
                    }
                }
            })
        });

        $('#btnDeleteAll').off('click').on('click', function () {

            $.ajax({
                url: '/Cart/DeleteAll',
                dateType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/Cart/index";
                    }
                }
            })
        });

        $('.btn-delete').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                data: {id: $(this).data('id')},
                url: '/Cart/DeleteAll',
                dateType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/Cart/index";
                    }
                }
            })
        });

    }
}
cart.init();