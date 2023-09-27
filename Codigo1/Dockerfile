FROM gcc:4.9

WORKDIR /app
COPY . /app/

RUN g++ -c calculo.cpp -o calculo.o
RUN g++ -c main.cpp -o main.o
RUN g++ main.o calculo.o -o programa

CMD [ "./programa" ]
