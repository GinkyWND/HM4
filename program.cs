<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - Кофейня «Аромат»</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" />
</head>
<body class="d-flex flex-column min-vh-100">
    <header>
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark shadow">
            <div class="container">
                <a class="navbar-brand fw-bold" asp-controller="Home" asp-action="Index">☕️ Кофейня «Аромат»</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav ms-auto">
                        <li class="nav-item">
                            <a class="nav-link text-white" asp-controller="Home" asp-action="Index">Главная</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-white" asp-controller="Home" asp-action="Menu">Меню</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-white" asp-controller="Home" asp-action="About">О нас</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-white" asp-controller="Home" asp-action="Contacts">Контакты</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>

    <main class="container my-5 flex-grow-1">
        @RenderBody()
    </main>

    <footer class="bg-dark text-white text-center py-3 mt-auto">
        <div class="container">
            <p class="mb-0">&copy; @DateTime.Now.Year Кофейня «Аромат». Все права защищены.</p>
        </div>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    @await RenderSectionAsync("Scripts", required: false)
</body>
</html>
