1. Projeto

Projeto desenvolvido com as seguintes tecnologias e metodologias:

* DotNet Core 8;
* C#
* DDD;
* Padrão Repository;
* Unit Of Work;
* Entity Framework Core;
* IoC;
* API Rest;
* Cleam Arch;
* Docker;
* SQL Server;
* Auto Mapper;

2. Configurar Ambiente

Para configurar o ambiente local, deve-se seguir os passos:

* Faça o clone deste repositório a partir da branch master em seu dispositivo local;
* Com o clone feito, vá até a pasta salva e abra o projeto no seu visual studio;
* Abra uma nova janela do commando para subir Docker utilizando o comando abaixo para criar a base de dados:
docker run -e 'ACCEPT_EULA=Y' -e "SA_PASSWORD=teste@ats!" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2019-latest
* No projeto, no package manager console, escolha o projeto Infra.Data e execute o comando update-database para atualizar a base de dados com as novas tabelas.
* Execute o projeto com F5 e as apis vão ser disponibilizadas via swagger;

  
Lembrando que o projeto vai ser criado vazio.

3. Testar Projeto

Para realizar os teste das apis, foi criada a collection no Postman abaixo:

 [Uploading PowerATS.API.postman_c{
	"info": {
		"_postman_id": "eb24f3a5-ef7d-4235-b7a4-4d667695b856",
		"name": "PowerATS.API",
		"schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json",
		"_exporter_id": "2921580",
		"_collection_link": "https://hsl-dev.postman.co/workspace/SIGAM-PLUS~4d910ccd-0f8e-4c62-9ba9-35fc2eafff7e/collection/2921580-eb24f3a5-ef7d-4235-b7a4-4d667695b856?action=share&source=collection_link&creator=2921580"
	},
	"item": [
		{
			"name": "Candidato",
			"item": [
				{
					"name": "/api/Candidato",
					"request": {
						"method": "GET",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/Candidato",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Candidato"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "GET",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/Candidato",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Candidato"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Candidato",
					"request": {
						"method": "POST",
						"header": [
							{
								"key": "Content-Type",
								"value": "application/json"
							}
						],
						"body": {
							"mode": "raw",
							"raw": "{\n  \"email\": \"tiladeira@gmail.com\",\n  \"idade\": \"42\",\n  \"nomeCompleto\": \"Thiago Ladeira\"\n}",
							"options": {
								"raw": {
									"headerFamily": "json",
									"language": "json"
								}
							}
						},
						"url": {
							"raw": "{{baseUrl}}/api/Candidato",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Candidato"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "POST",
								"header": [
									{
										"key": "Content-Type",
										"value": "application/json"
									}
								],
								"body": {
									"mode": "raw",
									"raw": "{\n  \"email\": \"<string>\",\n  \"idade\": \"<integer>\",\n  \"nomeCompleto\": \"<string>\",\n  \"id\": \"<uuid>\",\n  \"idCandidato\": \"<uuid>\"\n}",
									"options": {
										"raw": {
											"headerFamily": "json",
											"language": "json"
										}
									}
								},
								"url": {
									"raw": "{{baseUrl}}/api/Candidato",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Candidato"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Candidato",
					"request": {
						"method": "PUT",
						"header": [
							{
								"key": "Content-Type",
								"value": "application/json"
							}
						],
						"body": {
							"mode": "raw",
							"raw": "{\n    \"id\": \"0b3541c4-bdd9-4f17-903a-dbff44e57bb5\",\n    \"idCandidato\": \"c487c61f-ccb1-46ad-9222-2b594dcfdeb7\",\n    \"nomeCompleto\": \"Thiago Ladeira dos Santos\",\n    \"email\": \"tiladeira@gmail.com\",\n    \"idade\": 42\n}",
							"options": {
								"raw": {
									"headerFamily": "json",
									"language": "json"
								}
							}
						},
						"url": {
							"raw": "{{baseUrl}}/api/Candidato/c487c61f-ccb1-46ad-9222-2b594dcfdeb7",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Candidato",
								"c487c61f-ccb1-46ad-9222-2b594dcfdeb7"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "PUT",
								"header": [
									{
										"key": "Content-Type",
										"value": "application/json"
									}
								],
								"body": {
									"mode": "raw",
									"raw": "{\n  \"email\": \"<string>\",\n  \"idade\": \"<integer>\",\n  \"nomeCompleto\": \"<string>\",\n  \"id\": \"<uuid>\",\n  \"idCandidato\": \"<uuid>\"\n}",
									"options": {
										"raw": {
											"headerFamily": "json",
											"language": "json"
										}
									}
								},
								"url": {
									"raw": "{{baseUrl}}/api/Candidato",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Candidato"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Candidato/:id",
					"request": {
						"method": "GET",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/Candidato/c487c61f-ccb1-46ad-9222-2b594dcfdeb7",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Candidato",
								"c487c61f-ccb1-46ad-9222-2b594dcfdeb7"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "GET",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/Candidato/:id",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Candidato",
										":id"
									],
									"variable": [
										{
											"key": "id"
										}
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Candidato/:id",
					"request": {
						"method": "DELETE",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/Candidato/c487c61f-ccb1-46ad-9222-2b594dcfdeb7",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Candidato",
								"c487c61f-ccb1-46ad-9222-2b594dcfdeb7"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "DELETE",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/Candidato/:id",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Candidato",
										":id"
									],
									"variable": [
										{
											"key": "id"
										}
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				}
			]
		},
		{
			"name": "CandidatoVaga",
			"item": [
				{
					"name": "/api/CandidatoVaga",
					"request": {
						"method": "GET",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/CandidatoVaga",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"CandidatoVaga"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "GET",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/CandidatoVaga",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"CandidatoVaga"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/CandidatoVaga",
					"request": {
						"method": "POST",
						"header": [
							{
								"key": "Content-Type",
								"value": "application/json"
							}
						],
						"body": {
							"mode": "raw",
							"raw": "{\n  \"idCandidato\": \"c487c61f-ccb1-46ad-9222-2b594dcfdeb7\",\n  \"idVaga\": \"e0b12667-483b-4001-bee7-2efe932c2261\"\n}",
							"options": {
								"raw": {
									"headerFamily": "json",
									"language": "json"
								}
							}
						},
						"url": {
							"raw": "{{baseUrl}}/api/CandidatoVaga",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"CandidatoVaga"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "POST",
								"header": [
									{
										"key": "Content-Type",
										"value": "application/json"
									}
								],
								"body": {
									"mode": "raw",
									"raw": "{\n  \"idCandidato\": \"<uuid>\",\n  \"idVaga\": \"<uuid>\",\n  \"idCandidatoVaga\": \"<uuid>\",\n  \"id\": \"<uuid>\"\n}",
									"options": {
										"raw": {
											"headerFamily": "json",
											"language": "json"
										}
									}
								},
								"url": {
									"raw": "{{baseUrl}}/api/CandidatoVaga",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"CandidatoVaga"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/CandidatoVaga",
					"request": {
						"method": "PUT",
						"header": [
							{
								"key": "Content-Type",
								"value": "application/json"
							}
						],
						"body": {
							"mode": "raw",
							"raw": "{\n  \"idCandidato\": \"<uuid>\",\n  \"idVaga\": \"<uuid>\",\n  \"idCandidatoVaga\": \"<uuid>\",\n  \"id\": \"<uuid>\"\n}",
							"options": {
								"raw": {
									"headerFamily": "json",
									"language": "json"
								}
							}
						},
						"url": {
							"raw": "{{baseUrl}}/api/CandidatoVaga",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"CandidatoVaga"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "PUT",
								"header": [
									{
										"key": "Content-Type",
										"value": "application/json"
									}
								],
								"body": {
									"mode": "raw",
									"raw": "{\n  \"idCandidato\": \"<uuid>\",\n  \"idVaga\": \"<uuid>\",\n  \"idCandidatoVaga\": \"<uuid>\",\n  \"id\": \"<uuid>\"\n}",
									"options": {
										"raw": {
											"headerFamily": "json",
											"language": "json"
										}
									}
								},
								"url": {
									"raw": "{{baseUrl}}/api/CandidatoVaga",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"CandidatoVaga"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/CandidatoVaga/:id",
					"request": {
						"method": "GET",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/CandidatoVaga/:id",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"CandidatoVaga",
								":id"
							],
							"variable": [
								{
									"key": "id",
									"value": "<uuid>",
									"description": "(Required) "
								}
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "GET",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/CandidatoVaga/:id",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"CandidatoVaga",
										":id"
									],
									"variable": [
										{
											"key": "id"
										}
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/CandidatoVaga/:id",
					"request": {
						"method": "DELETE",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/CandidatoVaga/:id",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"CandidatoVaga",
								":id"
							],
							"variable": [
								{
									"key": "id",
									"value": "<uuid>",
									"description": "(Required) "
								}
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "DELETE",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/CandidatoVaga/:id",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"CandidatoVaga",
										":id"
									],
									"variable": [
										{
											"key": "id"
										}
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				}
			]
		},
		{
			"name": "Curriculo",
			"item": [
				{
					"name": "/api/Curriculo",
					"request": {
						"method": "GET",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/Curriculo",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Curriculo"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "GET",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/Curriculo",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Curriculo"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Curriculo",
					"request": {
						"method": "POST",
						"header": [
							{
								"key": "Content-Type",
								"value": "application/json"
							}
						],
						"body": {
							"mode": "raw",
							"raw": "{\n  \"curriculoDocumento\": \"curriculo.pdf\",\n  \"idCandidato\": \"c487c61f-ccb1-46ad-9222-2b594dcfdeb7\"\n}",
							"options": {
								"raw": {
									"headerFamily": "json",
									"language": "json"
								}
							}
						},
						"url": {
							"raw": "{{baseUrl}}/api/Curriculo",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Curriculo"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "POST",
								"header": [
									{
										"key": "Content-Type",
										"value": "application/json"
									}
								],
								"body": {
									"mode": "raw",
									"raw": "{\n  \"curriculoDocumento\": \"<string>\",\n  \"idCandidato\": \"<uuid>\",\n  \"idCurriculo\": \"<uuid>\",\n  \"id\": \"<uuid>\"\n}",
									"options": {
										"raw": {
											"headerFamily": "json",
											"language": "json"
										}
									}
								},
								"url": {
									"raw": "{{baseUrl}}/api/Curriculo",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Curriculo"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Curriculo",
					"request": {
						"method": "PUT",
						"header": [
							{
								"key": "Content-Type",
								"value": "application/json"
							}
						],
						"body": {
							"mode": "raw",
							"raw": "{\n  \"curriculoDocumento\": \"<string>\",\n  \"idCandidato\": \"<uuid>\",\n  \"idCurriculo\": \"<uuid>\",\n  \"id\": \"<uuid>\"\n}",
							"options": {
								"raw": {
									"headerFamily": "json",
									"language": "json"
								}
							}
						},
						"url": {
							"raw": "{{baseUrl}}/api/Curriculo",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Curriculo"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "PUT",
								"header": [
									{
										"key": "Content-Type",
										"value": "application/json"
									}
								],
								"body": {
									"mode": "raw",
									"raw": "{\n  \"curriculoDocumento\": \"<string>\",\n  \"idCandidato\": \"<uuid>\",\n  \"idCurriculo\": \"<uuid>\",\n  \"id\": \"<uuid>\"\n}",
									"options": {
										"raw": {
											"headerFamily": "json",
											"language": "json"
										}
									}
								},
								"url": {
									"raw": "{{baseUrl}}/api/Curriculo",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Curriculo"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Curriculo/:id",
					"request": {
						"method": "GET",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/Curriculo/:id",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Curriculo",
								":id"
							],
							"variable": [
								{
									"key": "id",
									"value": "<uuid>",
									"description": "(Required) "
								}
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "GET",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/Curriculo/:id",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Curriculo",
										":id"
									],
									"variable": [
										{
											"key": "id"
										}
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Curriculo/:id",
					"request": {
						"method": "DELETE",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/Curriculo/:id",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Curriculo",
								":id"
							],
							"variable": [
								{
									"key": "id",
									"value": "<integer>",
									"description": "(Required) "
								}
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "DELETE",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/Curriculo/:id",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Curriculo",
										":id"
									],
									"variable": [
										{
											"key": "id"
										}
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				}
			]
		},
		{
			"name": "Vaga",
			"item": [
				{
					"name": "/api/Vaga",
					"request": {
						"method": "GET",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/Vaga",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Vaga"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "GET",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/Vaga",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Vaga"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Vaga",
					"request": {
						"method": "POST",
						"header": [
							{
								"key": "Content-Type",
								"value": "application/json"
							}
						],
						"body": {
							"mode": "raw",
							"raw": "{\n  \"descricao\": \"Vaga interna da startup .....\",\n  \"status\": true,\n  \"tipoContratacao\": 2,\n  \"titulo\": \"Programador Java\",\n  \"valor\": \"21500\"\n}",
							"options": {
								"raw": {
									"headerFamily": "json",
									"language": "json"
								}
							}
						},
						"url": {
							"raw": "{{baseUrl}}/api/Vaga",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Vaga"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "POST",
								"header": [
									{
										"key": "Content-Type",
										"value": "application/json"
									}
								],
								"body": {
									"mode": "raw",
									"raw": "{\n  \"descricao\": \"<string>\",\n  \"status\": \"<boolean>\",\n  \"tipoContratacao\": 1,\n  \"titulo\": \"<string>\",\n  \"valor\": \"<double>\",\n  \"id\": \"<uuid>\",\n  \"idVaga\": \"<uuid>\"\n}",
									"options": {
										"raw": {
											"headerFamily": "json",
											"language": "json"
										}
									}
								},
								"url": {
									"raw": "{{baseUrl}}/api/Vaga",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Vaga"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Vaga",
					"request": {
						"method": "PUT",
						"header": [
							{
								"key": "Content-Type",
								"value": "application/json"
							}
						],
						"body": {
							"mode": "raw",
							"raw": "    {\n        \"id\": \"21c8d46d-95c2-41d6-9f3f-3461e2512e96\",\n        \"idVaga\": \"6e757a60-a5cb-47c3-90a2-8c1ce6fae33f\",\n        \"titulo\": \"Analista Programador DotNet\",\n        \"descricao\": \"Vaga para um grande cliente internacional....\",\n        \"valor\": 11500.00,\n        \"tipoContratacao\": 1,\n        \"status\": true\n    }",
							"options": {
								"raw": {
									"headerFamily": "json",
									"language": "json"
								}
							}
						},
						"url": {
							"raw": "{{baseUrl}}/api/Vaga",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Vaga"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "PUT",
								"header": [
									{
										"key": "Content-Type",
										"value": "application/json"
									}
								],
								"body": {
									"mode": "raw",
									"raw": "{\n  \"descricao\": \"<string>\",\n  \"status\": \"<boolean>\",\n  \"tipoContratacao\": 1,\n  \"titulo\": \"<string>\",\n  \"valor\": \"<double>\",\n  \"id\": \"<uuid>\",\n  \"idVaga\": \"<uuid>\"\n}",
									"options": {
										"raw": {
											"headerFamily": "json",
											"language": "json"
										}
									}
								},
								"url": {
									"raw": "{{baseUrl}}/api/Vaga",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Vaga"
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Vaga/:id",
					"request": {
						"method": "GET",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/Vaga/6e757a60-a5cb-47c3-90a2-8c1ce6fae33f",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Vaga",
								"6e757a60-a5cb-47c3-90a2-8c1ce6fae33f"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "GET",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/Vaga/:id",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Vaga",
										":id"
									],
									"variable": [
										{
											"key": "id"
										}
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				},
				{
					"name": "/api/Vaga/:id",
					"request": {
						"method": "DELETE",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/Vaga/6e757a60-a5cb-47c3-90a2-8c1ce6fae33f",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"Vaga",
								"6e757a60-a5cb-47c3-90a2-8c1ce6fae33f"
							]
						}
					},
					"response": [
						{
							"name": "Success",
							"originalRequest": {
								"method": "DELETE",
								"header": [],
								"url": {
									"raw": "{{baseUrl}}/api/Vaga/:id",
									"host": [
										"{{baseUrl}}"
									],
									"path": [
										"api",
										"Vaga",
										":id"
									],
									"variable": [
										{
											"key": "id"
										}
									]
								}
							},
							"status": "OK",
							"code": 200,
							"_postman_previewlanguage": "text",
							"header": [],
							"cookie": [],
							"body": ""
						}
					]
				}
			]
		},
		{
			"name": "Testes",
			"item": [
				{
					"name": "ValidarRota",
					"event": [
						{
							"listen": "test",
							"script": {
								"exec": [
									"pm.test(\"Status code is 200\", function() {\r",
									"    pm.response.to.have.status(200);\r",
									"});"
								],
								"type": "text/javascript"
							}
						}
					],
					"request": {
						"method": "GET",
						"header": [],
						"url": {
							"raw": "{{baseUrl}}/api/CandidatoVaga",
							"host": [
								"{{baseUrl}}"
							],
							"path": [
								"api",
								"CandidatoVaga"
							]
						}
					},
					"response": []
				}
			]
		}
	],
	"event": [
		{
			"listen": "prerequest",
			"script": {
				"type": "text/javascript",
				"exec": [
					""
				]
			}
		},
		{
			"listen": "test",
			"script": {
				"type": "text/javascript",
				"exec": [
					""
				]
			}
		}
	],
	"variable": [
		{
			"key": "baseUrl",
			"value": "https://localhost:7238"
		}
	]
}ollection.json…]()

