# Instalar dependências (caso necessário)
# pip install faiss-cpu transformers sentence-transformers

from sentence_transformers import SentenceTransformer
import faiss
import numpy as np

# 1. Carregar modelo de embeddings do HuggingFace
model = SentenceTransformer("sentence-transformers/all-MiniLM-L6-v2")

# 2. Base de textos para indexar
documents = [
    "O gato dormiu no sofá.",
    "Carros elétricos são o futuro da mobilidade.",
    "A inteligência artificial está transformando o mundo.",
    "Jogar futebol é divertido.",
    "Python é uma linguagem poderosa para ciência de dados."
]

# 3. Criar embeddings
embeddings = model.encode(documents)

# 4. Criar índice FAISS (vetor 384 dimensões para esse modelo)
dim = embeddings.shape[1]
index = faiss.IndexFlatL2(dim)

# 5. Adicionar os vetores ao índice
index.add(np.array(embeddings))

# 6. Consulta
query = "Tecnologia que está mudando a sociedade"
query_embedding = model.encode([query])

# 7. Buscar os 3 resultados mais semelhantes
k = 3
distances, indices = index.search(np.array(query_embedding), k)

print("Consulta:", query)
print("\nResultados mais similares:\n")
for i, idx in enumerate(indices[0]):
    print(f"{i+1}. {documents[idx]}  (distância: {distances[0][i]:.4f})")
