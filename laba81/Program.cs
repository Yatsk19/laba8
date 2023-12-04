class Graph(ABC) : @abstractmethod
    def draw(self):        pass

class LineGraph(Graph) : def draw(self):
        print("Drawing Line Graph")
class BarGraph(Graph) : def draw(self):
        print("Drawing Bar Graph")
class PieChart(Graph) : def draw(self):
        print("Drawing Pie Chart")
class GraphFactory(ABC) : @abstractmethod
    def create_graph(self):        pass
class LineGraphFactory(GraphFactory) :
    def create_graph(self):        return LineGraph()
class BarGraphFactory(GraphFactory) :
    def create_graph(self):        return BarGraph()
class PieChartFactory(GraphFactory) :
    def create_graph(self):        return PieChart()