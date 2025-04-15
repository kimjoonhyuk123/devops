from flask import Flask
import redis

app = Flask(__name__)
r = redis.Redis(host='redis', port=6379, decode_responses=True)

@app.route('/')
def index():
    count = r.incr('visits')
    return f"안녕! 너는 이 페이지를 {count}번 방문했어."

if __name__ == "__main__":
    app.run(host='0.0.0.0', port=5000)
