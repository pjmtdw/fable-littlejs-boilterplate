init:
	dotnet tool install fable
	dotnet restore
	npm install

watch:
	dotnet fable watch --run npx vite

build:
	dotnet fable --run npx vite build

