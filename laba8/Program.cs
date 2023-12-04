Singleton патернуclass ConfigurationManager:
    _instance = None
    def __new__(cls):        if cls._instance is None:
            cls._instance = super(ConfigurationManager, cls).__new__(cls)            cls._instance.config = { }
return cls._instance
    def get_configuration(self, key):        return self.config.get(key)
    def set_configuration(self, key, value):
        self.config[key] = value
    def save_configuration(self):        print("Configuration saved successfully.")