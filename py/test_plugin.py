import Ice

Ice.loadSlice(r"C:\Projects\tpp-desktop\api\ClientServerApi.ice")
import Api

class TestPlugin(Api.Plugin):
    def __init__(self, frontend_api):
        self.__frontend_api = frontend_api

    def execute(self, files, current=None):
        with open(r"C:\temp\test.txt", "wb") as f:
            f.write("3333")

    def shutdown(self, current=None):
        current.adapter.getCommunicator().shutdown()
