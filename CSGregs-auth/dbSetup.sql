CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';
CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS cars(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        make TEXT NOT NULL,
        model TEXT NOT NULL,
        imgUrl TEXT NOT NULL,
        year INT NOT NULL,
        price INT NOT NULL,
        description TEXT NOT NULL,
        color TEXT NOT NULL
    );

CREATE TABLE IF NOT EXISTS houses(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        bedrooms INT NOT NULL,
        bathrooms INT NOT NULL,
        levels INT NOT NULL,
        imgUrl TEXT NOT NULL,
        year INT NOT NULL,
        price INT NOT NULL,
        description TEXT NOT NULL
    );

CREATE TABLE IF NOT EXISTS jobs(
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    company TEXT NOT NULL,
    jobTitle TEXT NOT NULL,
    hours INT NOT NULL,
    rate INT NOT NULL,
    description TEXT NOT NULL
)