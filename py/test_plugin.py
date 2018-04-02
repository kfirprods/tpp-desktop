import Ice

Ice.loadSlice(r"C:\Projects\tpp-desktop\api\ClientServerApi.ice")
import Api

class TestPlugin(Api.Plugin):
    def execute(files):
        with open(r"C:\temp\test.txt", "wb") as f:
            f.write("2")
