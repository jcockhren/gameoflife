.PHONY: all


all: WorldTests.class CellTests.class

%.class: %.java $(DEPENDS)
	javac -cp './junit-4.12.jar:./hamcrest-core-1.3.jar:.' $<
	

test:
	java -cp './junit-4.12.jar:./hamcrest-core-1.3.jar:.' org.junit.runner.JUnitCore WorldTests


clean:
	rm -rf *.class
