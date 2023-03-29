const express = require("express")
const app = express()
const cors = require("cors")

app.use(cors())

app.get("/", function(req, res) {
  res.send({"name": "test name"})
})

app.get("/test/", function(req, res) {
  res.send({"name": "I really do win"})
})



app.listen(3000, () => {
  console.log("app listening on port 3000")
})