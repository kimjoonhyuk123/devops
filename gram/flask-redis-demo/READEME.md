# Flask + Redis DevOps 실습 프로젝트

이 프로젝트는 Docker와 Docker Compose를 사용하여  
Flask 웹 서버와 Redis 캐시 서버를 구성한 DevOps 실습입니다.

---

## 📦 구성 요소

- **Flask**: 웹 애플리케이션 서버
- **Redis**: 방문 횟수를 저장하는 캐시 시스템
- **Dockerfile**: Flask 앱을 컨테이너화
- **Docker Compose**: 멀티 컨테이너를 하나의 명령어로 실행

---

## 🚀 실행 방법

```bash
docker-compose up --build
```markdown

![실행 결과](flask-redis-demo/screenshots/web-result.png)

👉 브라우저에서 [http://localhost:5000](http://localhost:5000) 로 접속