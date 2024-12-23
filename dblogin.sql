CREATE TABLE dbsimplelogin.users (
  ID INT NULL,
  username VARCHAR(100) NULL,
  password VARCHAR(100) NULL,
  firstname VARCHAR(100) NULL,
  lastname VARCHAR(100) NULL,
  address VARCHAR(1000) NULL,
  PRIMARY KEY (ID));

INSERT INTO users (Id, username, userpwd, firstname, lastname, address) VALUES
(1, 'user1', '12345', 'Jerry', 'Timmin', '156 Elm Street, Toronto'),
(2, 'user2', '12345', 'Tony', 'Smith', '36 Frank Drive, Ricmond Hill'),
(3, 'user', '12345', 'Tina', 'Weiss', '89 Gavin Crt, BC') ;