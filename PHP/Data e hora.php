<html>
  <body>
    <p><b>Script no lado do cliente e no lado do servidor</b></p>
    <script type="text/JavaScript">
      document.write("Data do cliente: " + Date() + "<br/>");
    </script>

    <?php
      date_default_timezone_set("America/Sao_Paulo");
      echo "Data do servidor é " . date("Y-m-d");
      echo "A hora é " . date("h:i:sa");
    ?>
  </body>
</html>